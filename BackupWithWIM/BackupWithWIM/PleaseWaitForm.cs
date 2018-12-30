using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupWithWIM
{
    public partial class PleaseWaitForm : Form
    {
        List<String> AvalibleVolumes;
        String destinationPath;
        List<Disk> targetDisk = null;
        bool FormatDrive = false;
        bool QuickFormat = false;
        FileInfo filePathToImage = null;

        public PleaseWaitForm(List<String> AvalibleVolumes, String destinationPath)
        {
            InitializeComponent();
            this.AvalibleVolumes = AvalibleVolumes;
            this.destinationPath = destinationPath;
        }

        public PleaseWaitForm(List<Disk> targetDisk, FileInfo filePathToImage, bool FormatDrive, bool QuickFormat) {
            InitializeComponent();
            this.targetDisk = targetDisk;
            this.filePathToImage = filePathToImage;
            this.FormatDrive = FormatDrive;
            this.QuickFormat = QuickFormat;
        }


        private void PleaseWaitForm_Shown(object sender, EventArgs e)  //this is where we dispatch our blocking method calls so we don't hang tha application thread.
        {
            Application.DoEvents();

            if (this.targetDisk.Count == 0)
            {
                Program.captureImages(this.AvalibleVolumes, this.destinationPath);
                MessageBox.Show("Image Captured");
            }
            else if (this.targetDisk.Count < 0)
            {
                Program.ApplyImageToDisk(targetDisk, this.filePathToImage.ToString(), this.FormatDrive, this.QuickFormat);
                MessageBox.Show("Image Applied");
            }
            this.Close();

        }


    }
}
