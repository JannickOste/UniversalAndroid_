using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid
{
    class ShellClient : SharpAdbClient.IShellOutputReceiver
    {
        public ShellClient(SharpAdbClient.DeviceData target_device)
        {
            this.target_device = target_device;
        }

        public SharpAdbClient.DeviceData target_device { get;  private set; }

        public bool ParsesErrors { get; }
        public List<String> output = new List<String>();

        public void AddOutput(string line)
        {
            output.Add(line);
        }

        public void Flush()
        {
        }

        public void FlushOutput()
        {
            this.output.Clear();
        }

        public void ExecuteCommand(string command, int maxOutputTime = 1000)
        {
            SharpAdbClient.AdbClient.Instance.ExecuteRemoteCommandAsync(command, target_device, this, new System.Threading.CancellationToken(), maxOutputTime);
        }
    }
}
