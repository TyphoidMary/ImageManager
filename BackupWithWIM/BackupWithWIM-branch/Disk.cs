using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WimgApi;

namespace BackupWithWIM
{
    class Disk
    {
        DriveInfo drive;

        public Disk(DriveInfo drive)
        {
            this.drive = drive;
        }

        public WindowsImageContainer CreateImageContainer(string Destination)
        {

            WindowsImageContainer image = new WindowsImageContainer(Destination, WindowsImageContainer.CreateFileMode.CreateAlways, WindowsImageContainer.CreateFileAccess.Write);

            return image;


        }

        public DriveInfo GetDrive() {
            return this.drive;
        }

        public void SetDrive(DriveInfo newDrive) { 
            this.drive = newDrive;
        }
    }
}