using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpAdbClient;
using UniversalAndroid.Forms.Menus;

namespace UniversalAndroid.Forms.UIPanels
{
    public partial class ShellPrompt : UserControl
    {
        DeviceData target_device = null;

        public ShellPrompt()
        {
            InitializeComponent();
        }

        private void introPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            TaskHandler.createGuardedTask("shell_guard", new Action(() =>
            {
                var connected_devices = AdbClient.Instance.GetDevices();
                if (connected_devices.Count() == 0 || target_device == null)
                {
                    BeginInvoke((MethodInvoker)delegate
                    {
                        Program.setRenderingPanel(new StartScreen());
                        TaskHandler.cancelTasksWithKey("shell_guard");
                        MessageBox.Show("Target device has been disconnected, went back to main menu...");
                    });
                }
            }));


            var client_list = AdbClient.Instance.GetDevices();
            if(client_list.Count() == 1)
            {
                target_device = client_list.FirstOrDefault();
                this.introPanel.Visible = false;
                this.introPanel.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            var command = textBox1.Text;
            if (e.KeyValue == 13 || e.KeyCode == Keys.Enter)
            {
                textBox1.Clear();

                var shellout = new ShellClient(target_device);
                // Listdir path formating
                if (command.StartsWith("ls") && (command.Split().Count() == 1 || !command.Split()[1].StartsWith("/")))
                    command = command.Insert(command.Split().Count() > 1 ? command.IndexOf(command.Split()[1]) : 2, String.Format("{0}{1}", command.Split().Count() == 1 ? " " : "", this.pathLabel.Text));

                AdbClient.Instance.ExecuteRemoteCommand(command, target_device, shellout);
                
                foreach (var result in shellout.output)
                {
                    this.listView1.Items.Add(result);
                }

                // Path setting.
                if (command.StartsWith("cd") && shellout.output.Count == 0)
                {
                    this.pathLabel.Text = command.Split()[1].StartsWith("/") ? command.Split()[1] : 
                        string.Format("{0}{1}{2}", this.pathLabel.Text, command.Split()[1], command.Split()[1].EndsWith("/") ? "" : "/");
                }
                shellout.FlushOutput();
                

            }
            Console.WriteLine(e.KeyValue);
            Console.WriteLine(e.KeyCode);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.setRenderingPanel(new StartScreen());
            TaskHandler.cancelTasksWithKey("shell_guard");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
