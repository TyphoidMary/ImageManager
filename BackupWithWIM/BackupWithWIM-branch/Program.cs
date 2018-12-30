using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;

using Microsoft.WimgApi;
using Microsoft.Wim;
using System.Management.Automation.Runspaces;

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
            Application.Run(new TotalImageManger());
            
        }

        public static List<Disk> GetVolumes(){
            List<Disk> AvailibleVolumesList = new List<Disk>();
            
              foreach(DriveInfo drive in DriveInfo.GetDrives()){
                AvailibleVolumesList.Add(new Disk(drive));
             }

            return AvailibleVolumesList;
        }

        public static List<WindowsImageContainer> CreateImageFile(string destinationFolder, List<Disk> SelectedDisks) {

            List<WindowsImageContainer> imageFiles = new List<WindowsImageContainer>();

            foreach (Disk selectedDisk in SelectedDisks) {
               imageFiles.Add(selectedDisk.CreateImageContainer(destinationFolder));
            }

            return imageFiles;
        }


        public static void ImageWithDISM(string PathToWim, Dictionary<string, bool> options) {

            string bootCodeType;
            string DiskPartscript;

            if (options["NTDLRBootCodeType"]) 
            {
                bootCodeType = @"/nt52";
            }
            else 
            {
                bootCodeType = @"/nt60";
            }

            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();


            // Call the Create() method to create the PowerShell 
            // object, and then specify the runspace and 
            // create the pipeline.
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;


            /*
            *  The options dictionary is a key value in the exact order of the XML in the app.config file.
            */

            /*
            if (options["FormatDisk"])
            {
                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C ./diskpart /s ./XPDeployDiskpartScript.txt";
                    process.StartInfo = startInfo;
                    process.Start();

                }
            }
           
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                String ArgumentsString = @"/C Dism /apply-image /imagefile: " + PathToWim + @"/index:1 /ApplyDir:W:\";
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = ArgumentsString; 
                process.StartInfo = startInfo;
                process.Start();

            }

            if (options["WriteBootSector"])
            {
                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    String ArgumentsString = "/C bootsect.exe " + bootCodeType + "W: /mbr /force";
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = ArgumentsString;
                    process.StartInfo = startInfo;
                    process.Start();

                }

            }
            */
        }


    }
}
