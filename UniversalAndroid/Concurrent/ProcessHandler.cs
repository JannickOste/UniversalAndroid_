using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid
{
    class ProcessHandler
    {
        public struct ProcessContainer
        {
            public List<string> output;
            public bool error_occured;
            public bool isCompleted;
        }

        public static ProcessContainer GetExternalProcess(
            string pathToExecutable, string arguments = null, bool redirectOutput = true, bool redirectError = true, bool redirectInput = false, bool useNoWindow = true, bool useShellExecute = false,
            int timeout = 2000
        )
        {
            if (!System.IO.File.Exists(pathToExecutable)) throw new FileNotFoundException();
            var proc = new Process();
            var proc_out = new ProcessContainer();
            proc_out.output = new List<string>();
            
            /**
             * Assign parameterized values.
             */

            proc.StartInfo.FileName = pathToExecutable;
            if (!(string.IsNullOrEmpty(arguments) | string.IsNullOrWhiteSpace(arguments))) proc.StartInfo.Arguments = arguments;
            proc.StartInfo.RedirectStandardOutput = redirectOutput;
            proc.StartInfo.RedirectStandardError = redirectError;
            proc.StartInfo.RedirectStandardInput = redirectInput;

            proc.StartInfo.CreateNoWindow = useNoWindow;
            proc.StartInfo.UseShellExecute = useShellExecute;

            /**
             * Default output event.
             */
            proc.OutputDataReceived += (s, e) =>
            {
                if (e.Data != null) proc_out.output.Add(e.Data);
                proc_out.error_occured = false;
            };

            /**
             * Error output event.
             */
            proc.ErrorDataReceived += (s, e) =>
            {
                if (e.Data != null) proc_out.output.Add(e.Data);

                proc_out.error_occured = true;
            };

            /**
             * Exiting event.
             */
            proc.Exited += (s, e) =>
            {
                proc_out.isCompleted = proc.HasExited;
                
            };

            /**
             * Attempt to start process and run within given timeout frame.
             */

            if (proc.Start())
            {
                // Start reads required to be able to flag events.
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                proc.WaitForExit(timeout);
                if (!proc.HasExited) throw new TimeoutException();
                else return proc_out;
            }

            throw new InvalidOperationException(String.Format("Unable to start process: {0}", pathToExecutable));
        }
    }
}
