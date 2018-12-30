using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections;


namespace BackupWithWIM
{
    class VMCreate
    {
        List<string> imageFilePaths;
        string VMName;
        int VMMemoryInMB;
        string VMLocation;
        string vSwitch;
        string HyperVServerName;

        public VMCreate(List<string> ImageFilePathCollection, String VMName, int VMRAM, String VMLocation, String HyperVServerName) {
            this.imageFilePaths = ImageFilePathCollection;
            this.VMName = VMName;
            this.VMLocation = VMLocation;
            this.VMMemoryInMB = VMRAM;
            this.HyperVServerName = HyperVServerName;
        }

      


    }
}
