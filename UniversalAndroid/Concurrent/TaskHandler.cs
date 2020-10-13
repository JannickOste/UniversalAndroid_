using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UniversalAndroid
{
    class TaskHandler
    {
        private static Dictionary<string, CancellationTokenSource> cancelation_sources = new Dictionary<string, CancellationTokenSource>();

        /**
         *  Create a asynchronous background task with a specified group key to be able to kill a group simontaniously, task will loop if break on finish is not enabled.
         */
        public static void createGuardedTask(string cancel_source_key, Action thread_action, bool break_on_finish = false, int thread_update_time_in_ms = 2000)
        {
            // If no cancelation source exists or has been cancelation requested (re)-insert a new cancelation token.
            if (!cancelation_sources.ContainsKey(cancel_source_key) || cancelation_sources[cancel_source_key].IsCancellationRequested)
            {
                if (cancelation_sources.ContainsKey(cancel_source_key)) cancelation_sources.Remove(cancel_source_key);

                cancelation_sources.Add(cancel_source_key, new CancellationTokenSource());
            } 

            var task = Task.Run(async () =>
            {
                var token = cancelation_sources[cancel_source_key].Token;
                while (true)
                {
                    token.ThrowIfCancellationRequested();

                    thread_action();

                    if (break_on_finish) break;

                    await Task.Delay(thread_update_time_in_ms);
                }
            });

        }

        /**
         *  Cancel all running background tasks regardless of the group key specified for them.
         */
        public static void cancelAll()
        {
            foreach (var source in cancelation_sources.Values)
                source.Cancel();
        }

        /**
         *  Kill all specified tasks with a certain group key if the cancelation group key has been specified.
         */
        public static void cancelTasksWithKey(string key)
        {
            if (cancelation_sources.Keys.Contains(key))
            {
                cancelation_sources[key].Cancel();
            }
        }
    }
}
