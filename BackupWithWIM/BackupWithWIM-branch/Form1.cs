using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.WimgApi;

namespace BackupWithWIM
{
    public partial class TotalImageManger : Form
    {
        protected int lastTabIndex; 
        public TotalImageManger()
        {
            InitializeComponent();
            lastTabIndex = TabContainerPane.SelectedIndex;

            foreach (Disk d in Program.GetVolumes())
                if (d.GetDrive().IsReady)
                {
                    AvalibleVolumes.Items.Add(d.GetDrive().Name + " " + ((d.GetDrive().TotalSize - d.GetDrive().TotalFreeSpace) / 1000000000) + " " + "GB Used");
                    AvailibleDisks.Items.Add(d.GetDrive().Name + " " + ((d.GetDrive().TotalSize - d.GetDrive().TotalFreeSpace) / 1000000000) + " " + "GB Used");
                }
            AvalibleVolumes.ClientSize = new Size((AvalibleVolumes.ClientSize.Width * 3), AvalibleVolumes.GetItemRectangle(0).Height * AvalibleVolumes.Items.Count);
            AvailibleDisks.ClientSize = new Size((AvailibleDisks.ClientSize.Width * 3), AvailibleDisks.GetItemRectangle(0).Height * AvailibleDisks.Items.Count);

            ImageRepoPathTextBox.Text = ConfigurationManager.AppSettings["RepoPath"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                DestinationPathTextbox.Text = saveFileDialog1.FileName;
            }
        }

       

        private List<FileInfo> FullDirList(DirectoryInfo dir, string searchPattern)
        {
             List<FileInfo> files = new List<FileInfo>();

            // Console.WriteLine("Directory {0}", dir.FullName);
            // list the files
                foreach (FileInfo f in dir.GetFiles(searchPattern))
                {
                    //Console.WriteLine("File {0}", f.FullName);
                    files.Add(f);
                }

                return files;
        }


        private void CaptureImages_Click(object sender, EventArgs e)
        {
            List<Disk> selectedDisks = new List<Disk>();
            foreach (string d in AvalibleVolumes.SelectedItems)
            {
               foreach(DriveInfo drive in DriveInfo.GetDrives()){
                   if(d.Substring(0,3).Equals(drive.Name)){
                       selectedDisks.Add(new Disk(drive)); 
                   }
               }
                
            }

            List<WindowsImageContainer> imageFiles = Program.CreateImageFile(DestinationPathTextbox.Text, selectedDisks);

            int i = 0;
            foreach (WindowsImageContainer image in imageFiles)
            {
                image.CaptureImage(selectedDisks[i].GetDrive().Name.Substring(0,2));
            }


        }
    
        private void TabContainerPane_TabIndexChanged(object sender, EventArgs e)
        {
            
            if (TabContainerPane.SelectedIndex == 1){
                    DirectoryInfo info = new DirectoryInfo(ConfigurationManager.AppSettings["RepoPath"]);

                    if (Directory.Exists(ConfigurationManager.AppSettings["RepoPath"]))
                    {
                        foreach (FileInfo file in FullDirList(info, "*.wim"))
                        {
                            AvailibleImages.Items.Add(file);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check the Repo path (in the settings tab) and try again.");
                    }
                }
            else if (TabContainerPane.SelectedIndex != 2 && lastTabIndex == 2)
            {


                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["WriteBootSector"].Value = WriteBootSectorCheckBox.Checked.ToString();
                configuration.AppSettings.Settings["FormatDisk"].Value = FormatDriveCheckBox.Checked.ToString();

                if (QuickFormatRadioButton.Checked)
                {
                    configuration.AppSettings.Settings["FormatType"].Value = "quick";
                }
                else {
                    configuration.AppSettings.Settings["FormatType"].Value = "normal";
                }
                    
                configuration.Save();

                ConfigurationManager.RefreshSection("appSettings");


                }
            else if (TabContainerPane.SelectedIndex == 2) {

                    ImageRepoPathTextBox.Text = ConfigurationManager.AppSettings["RepoPath"];

                if (ConfigurationManager.AppSettings["WriteBootSector"].Equals("true")) {
                    WriteBootSectorCheckBox.Checked = true;
                }

                if (ConfigurationManager.AppSettings["FormatDisk"].Equals("true")) {
                    FormatDriveCheckBox.Checked = true;
                }

                if(ConfigurationManager.AppSettings["ImageCompression"].Equals("true"))
                {
                    CompressionCheckBox.Checked = true;
                }

                if (ConfigurationManager.AppSettings["FormatType"].Equals("true"))
                    {
                    QuickFormatRadioButton.Checked = true;
                    }
                else {
                    StandardFormatRadioButton.Checked = true;
                }
            }
          else if (TabContainerPane.SelectedIndex == 3) {
              TotalImageManagerAbout about = new TotalImageManagerAbout();
                  var result = about.ShowDialog();
                  TabContainerPane.SelectedIndex = lastTabIndex;
                }
          else
            {
                return;
            }

            lastTabIndex = TabContainerPane.SelectedIndex;

        }

       
    }
}
