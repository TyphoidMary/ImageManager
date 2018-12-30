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
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.WimgApi;
using System.Diagnostics;
using System.Threading;

namespace BackupWithWIM
{
    public partial class TotalImageManager : Form
    {
        protected List<string> vSwitches = null;
        protected int lastTabIndex;
        Configuration configuration;
        public TotalImageManager()
        {
            InitializeComponent();

            configuration  = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            lastTabIndex = HyperVServerHostnameTextbox.SelectedIndex;

            foreach (Disk d in Program.GetVolumes())
                if (d.GetDrive().IsReady)
                {
                    AvalibleVolumes.Items.Add(d.GetDrive().Name + " " + ((d.GetDrive().TotalSize - d.GetDrive().TotalFreeSpace) / 1000000000) + " " + "GB Used" + " " + d.GetDrive().DriveFormat);
                    AvailibleDisks.Items.Add(d.GetDrive().Name + " " + ((d.GetDrive().TotalSize - d.GetDrive().TotalFreeSpace) / 1000000000) + " " + "GB Used" + " " + d.GetDrive().DriveFormat);
                }
            AvalibleVolumes.ClientSize = new Size((AvalibleVolumes.ClientSize.Width * 4), AvalibleVolumes.GetItemRectangle(0).Height * AvalibleVolumes.Items.Count);
            AvailibleDisks.ClientSize = new Size((AvailibleDisks.ClientSize.Width * 4), AvailibleDisks.GetItemRectangle(0).Height * AvailibleDisks.Items.Count);

            ImageRepoPathTextBox.Text = Properties.Settings.Default.DefaultImageStore;
            VMRepoPathTextbox.Text = Properties.Settings.Default.VMRepoPath;
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
            List<String> vols = new List<string>();
            foreach(string disk in AvalibleVolumes.SelectedItems){
                vols.Add(disk);
            }

            PleaseWaitForm form = new PleaseWaitForm(vols, DestinationPathTextbox.Text);
            form.Show();

        }

        private void TabContainerPane_TabIndexChanged(object sender, EventArgs e)
        {
            #region
            if (HyperVServerHostnameTextbox.SelectedIndex == 1){
                    DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.DefaultImageStore);

                    if (Directory.Exists(Properties.Settings.Default.DefaultImageStore))
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
            #endregion
            else if (HyperVServerHostnameTextbox.SelectedIndex != 2 && lastTabIndex == 2)
            {

               

               
                configuration.AppSettings.Settings["WriteBootSector"].Value = WriteBootSectorCheckBox.Checked.ToString();
                configuration.AppSettings.Settings["FormatDisk"].Value = FormatDriveCheckBox.Checked.ToString();

                if (QuickFormatRadioButton.Checked)
                {
                    configuration.AppSettings.Settings["FormatType"].Value = "quick";
                }
                else {
                    configuration.AppSettings.Settings["FormatType"].Value = "normal";
                }

                configuration.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");


                }
            else if (HyperVServerHostnameTextbox.SelectedIndex == 2) {

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
            else
            {
                lastTabIndex = HyperVServerHostnameTextbox.SelectedIndex;
                return;
            }

            lastTabIndex = HyperVServerHostnameTextbox.SelectedIndex;
        }
        
        private void ImageDriveButton_Click(object sender, EventArgs e)
        {
            
            List<Disk> TargetDisks = new List<Disk>();

            foreach (string d in AvailibleDisks.SelectedItems)
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (d.Substring(0, 3).Equals(drive.Name))
                    {
                        TargetDisks.Add(new Disk(drive));
                    }
                }

            }

            FileInfo imageFile = (FileInfo)AvailibleImages.SelectedItem;

            PleaseWaitForm form = new PleaseWaitForm(TargetDisks, imageFile, FormatDriveCheckBox.Checked, QuickFormatRadioButton.Checked);
            form.Show();

        }
          
        private void SelectImageRepoButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            ImageRepoPathTextBox.Text = fbd.SelectedPath;
            Properties.Settings.Default.DefaultImageStore = fbd.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void SelectVMRepoButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            VMRepoPathTextbox.Text = fbd.SelectedPath;
            Properties.Settings.Default.VMRepoPath = fbd.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void EnableVDICheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (EnableVDICheckbox.Checked)
            {
                VDIServerHostnameTextbox.Enabled = true;
                VDIServerHostnameTextbox.Text = Properties.Settings.Default.VDIServerHostname;
                HyperVServerHostnameLabel.Enabled = true;
                VMRepoPathTextbox.Enabled = true;
                SelectVMRepoButton.Enabled = true;
                AvailiblevSwitchesCheckedListBox.Enabled = true;
                TestServerConnection.Enabled = true;
            }
            else 
            {
                VDIServerHostnameTextbox.Enabled = false ;
                HyperVServerHostnameLabel.Enabled = false;
                VMRepoPathTextbox.Enabled = false;
                SelectVMRepoButton.Enabled = false;
                AvailiblevSwitchesCheckedListBox.Enabled = false;
                TestServerConnection.Enabled = false;
            }
                
             
        }

        private void TestServerConnection_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(HyperVServerPasswordTextbox.Text) || String.IsNullOrWhiteSpace(HyperVServerPasswordTextbox.Text)) {
                MessageBox.Show("Error connecting to Hyper-V server: Please enter a password ", "Error connecting to Hyper-V server",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WaitBoxImage.Visible = true;
            BackgroundWorker bw = new BackgroundWorker();

            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                
                GetHyperVSwitches(bw); 
            });
            bw.ProgressChanged += new ProgressChangedEventHandler(delegate(object o, ProgressChangedEventArgs args){
                if (args.ProgressPercentage == 1) {
                    PingPassedLabel.Visible = true;
                }
                else if (args.ProgressPercentage == 2) {
                    GetvSwitchLabel.Visible = true;
                }
                else if (args.ProgressPercentage == 3) {
                    PingPassedLabel.Visible = false;
                }
            });
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args)
            {
                WaitBoxImage.Visible = false;
                if (vSwitches != null)
                {
                    GetvSwitchLabel.Visible = true;
                    foreach (string vSwitch in vSwitches)
                    {
                        AvailiblevSwitchesCheckedListBox.Items.Add(vSwitch);
                    }
                }
            });

            bw.RunWorkerAsync();
            
        }
       
        private void GetHyperVSwitches(BackgroundWorker b) {

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128, 
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted. 
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(VDIServerHostnameTextbox.Text, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                b.ReportProgress(1);

                try
                {
                    vSwitches = Program.GetVMSwitch(VDIServerHostnameTextbox.Text, HyperVUsernameTextbox.Text, HyperVServerPasswordTextbox.Text);
                }
                catch (Exception ex)
                {
                    b.ReportProgress(3);
                    MessageBox.Show("Error connecting to Hyper-V server: \n " + ex.Message, "Error connecting to Hyper-V server",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PingPassedLabel.Visible = false;
                }
                finally
                {
                    if (vSwitches != null) {
                        b.ReportProgress(2);
                    }
                   
                }

                

            }
        }

        private void VDIServerHostnameTextbox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VDIServerHostname = VDIServerHostnameTextbox.Text;
            Properties.Settings.Default.Save();
        }

        private void HyperVUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VDIServerUsername = HyperVUsernameTextbox.Text;
            Properties.Settings.Default.Save();
        }

   
    }
}
