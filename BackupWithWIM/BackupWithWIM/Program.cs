using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WimgApi;
using Microsoft.Wim;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Threading;
using System.ComponentModel;

namespace BackupWithWIM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TotalImageManager());

        }

        public static List<Disk> GetVolumes()
        {
            List<Disk> AvailibleVolumesList = new List<Disk>();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                AvailibleVolumesList.Add(new Disk(drive));
            }

            return AvailibleVolumesList;
        }

        public static List<WindowsImageContainer> CreateImageFile(string destinationFolder, List<Disk> SelectedDisks)
        {
            List<WindowsImageContainer> imageFiles = new List<WindowsImageContainer>();

            foreach (Disk selectedDisk in SelectedDisks)
            {
                imageFiles.Add(selectedDisk.CreateImageContainer(destinationFolder));
            }

            return imageFiles;
        }
        //Note:  the imagePath must always be literal escaped
        public static async void ApplyImageToDisk(List<Disk> targetDisks, string imagePath, bool formatDrive, bool quickFormat)
        {
            

            foreach (Disk targetDisk in targetDisks)
            {
               
                string targetPath = targetDisk.GetDrive().Name;

                if (formatDrive) {
                    await Task.Run(() =>
                    {
                        FormatDrives.FormatDrive(targetPath.Substring(0, 1).ToCharArray()[0], "", "NTFS", quickFormat, false, null);
                    });
                }

                // .wim files contain multiple images.  You must specify the image index when interacting
                // with them.  The index is 1-based meaning index range is 1-N.
                //
                int imageIndex = 1;

                // Get a handle to the .wim container
                //
               // try
                //{
                    using (var wimHandle = WimgApi.CreateFile(
                        imagePath,
                        WimFileAccess.Read,
                        WimCreationDisposition.OpenExisting,
                        WimCreateFileOptions.None,
                        WimCompressionType.None))
                    {
                        // Always set a temporary path
                        //
                        WimgApi.SetTemporaryPath(wimHandle, Environment.GetEnvironmentVariable("TEMP"));

                        // Get a handle to a specific image inside of the .wim
                        //
                        using (var imageHandle = WimgApi.LoadImage(wimHandle, imageIndex))
                        {
                            // Apply the image
                            //
                            await Task.Run(() =>
                           {
                               WimgApi.ApplyImage(imageHandle, targetPath, WimApplyImageOptions.None);
                           });
                        }
                    }
               // }
                //catch (IOException) { //Capturing images seems to leave a dangling handle
                
                    

                //}
            }
        }

        public static List<string> GetVMSwitch(string HyperVServerName, string username, string password)
        {
            string text = System.IO.File.ReadAllText(@".\Get-VMSwitches.ps1");


            List<string> VMSwitchNames = new List<string>();

            Runspace HyperVRunspace = RunspaceFactory.CreateRunspace();
            HyperVRunspace.Open();


            Pipeline pipeline = HyperVRunspace.CreatePipeline();
            Command command = new Command(text, true);
            command.Parameters.Add("username", username);
            command.Parameters.Add("password", password);
            command.Parameters.Add("hostName", HyperVServerName);
            pipeline.Commands.Add(command);


            Collection<System.Management.Automation.PSObject> results = pipeline.Invoke();
            foreach (System.Management.Automation.PSObject result in results)
            {
                VMSwitchNames.Add(result.ToString());
            }

            return VMSwitchNames;
       
        }

       public static void captureImages(List<String> AvalibleVolumes, String destinationPath)
        {

            List<Disk> selectedDisks = new List<Disk>();
            foreach (string d in AvalibleVolumes)
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (d.Substring(0, 3).Equals(drive.Name))
                    {
                        selectedDisks.Add(new Disk(drive));
                    }
                }

            }

            #region
            BackgroundWorker bw = new BackgroundWorker();

            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
            {



                BackgroundWorker b = o as BackgroundWorker;

                List<WindowsImageContainer> imageFiles = Program.CreateImageFile(destinationPath, selectedDisks);

                int i = 0;
                foreach (WindowsImageContainer image in imageFiles)
                {
                    image.CaptureImage(selectedDisks[i].GetDrive().Name.Substring(0, 2));
                    image.Dispose();
                }



                MessageBox.Show("Image captured");

            });

            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args)
            {


            });


            bw.RunWorkerAsync();




            #endregion


        }

    }
}
