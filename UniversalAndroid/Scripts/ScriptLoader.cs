using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid.Scripts
{
    class ScriptLoader
    {
        private List<ScriptModel> script_stack = new List<ScriptModel>();

        public ScriptLoader()
        {
            try
            {
                // Auto load script models.
                this.script_stack.AddRange(
                    Assembly.GetExecutingAssembly().GetTypes()
                        .Where(t => t.Namespace.StartsWith("UniversalAndroid.Scripts.Models"))
                        .Select(i => (ScriptModel)Activator.CreateInstance(i)).ToArray()
                );

                Console.WriteLine("[ScriptLoader]: Succesfully loaded {0} script(s).", this.script_stack.Count());
            } 
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred during script initiation:\n- {0}", ex.Message);
            }

        }

        public ScriptModel loadScriptByName(string script_name)
        {
            if (!this.getScriptInfo().Select(i => i.name).Contains(script_name)) throw new ArgumentException();

            return this.script_stack.Where(i => i.Name.Equals(script_name)).FirstOrDefault();
        }

        public IEnumerable<(string name, string description, System.Drawing.Image icon)> getScriptInfo()
        {
            return this.script_stack.Select(i => (i.Name, i.Description, i.ImageIcon));
        }
    }
}
