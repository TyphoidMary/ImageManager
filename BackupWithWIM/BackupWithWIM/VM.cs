using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.ComponentModel;

namespace BackupWithWIM
{
    class VM
    {
        public int vCPUs
        {
            get
            {
                return vCPUs;
            }
            set
            {
                vCPUs = value;
            }
        }
        public int RAMinMB
        {
            get
            {
                return RAMinMB;
            }
            set
            {
                RAMinMB = value;
            }
        }
        //public int numberOfNICs
        //{
        //    get
        //    {
        //        return numberOfNICs;
        //    }
        //    set
        //    {
        //        numberOfNICs = value;
        //    }
        //}
        public string vSwitchToAttachTo
        {
            get
            {
                return vSwitchToAttachTo;
            }
            set
            {
                vSwitchToAttachTo = value;
            }
        }
        public string PathTovDisk
        {
            get
            {
                return PathTovDisk;
            }
            set
            {
                PathTovDisk = value;
            }
        }
        public string VMName 
        {
            get 
            {
                return VMName;
            }
            set
            {
                VMName = value;
            }
        }

        public VM(int vCPUs, int RAMinMB, int numberOfNICs, string vSwitchToAttachTo, string PathTovDisk, string VMname) {
            this.vCPUs = vCPUs;
            this.RAMinMB = RAMinMB;
         // this.numberOfNICs = numberOfNICs; TODO patch in support for creating VMs with multiple NICs
            this.vSwitchToAttachTo = vSwitchToAttachTo;
            this.PathTovDisk = PathTovDisk;
            this.VMName = VMname;
        }

        public List<String> CreateVM(String vmName, String username, String password, String HyperVServerName)
        {
            List<String> CreateVMScriptResults = new List<String>();
            Runspace HyperVRunspace = RunspaceFactory.CreateRunspace();
            HyperVRunspace.Open();

            string text = System.IO.File.ReadAllText(@".\Create-VM.ps1");
            Pipeline pipeline = HyperVRunspace.CreatePipeline();
            Command command = new Command(text, true);
            command.Parameters.Add("username", username);
            command.Parameters.Add("password", password);
            command.Parameters.Add("hostName", HyperVServerName);
            command.Parameters.Add("Name", this.VMName);
            command.Parameters.Add("MemoryStartyupBytes", this.RAMinMB);
            command.Parameters.Add("VHDPath", this.PathTovDisk);
            command.Parameters.Add("Switchname", this.vSwitchToAttachTo);
            command.Parameters.Add("vCPUCount", this.vCPUs);
            command.Parameters.Add("vNICCount", 1);

            pipeline.Commands.Add(command);

            BackgroundWorker bw = new BackgroundWorker();

            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(delegate (object o, DoWorkEventArgs args)
            {
                
                Collection<System.Management.Automation.PSObject> results = pipeline.Invoke();
                foreach (System.Management.Automation.PSObject result in results)
                {
                    CreateVMScriptResults.Add(results.ToString());
                }

                
            });

            bw.RunWorkerAsync();

            return CreateVMScriptResults;
        }




    }
}
