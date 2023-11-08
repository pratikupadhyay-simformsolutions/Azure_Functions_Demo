using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure_Functions_Demo
{
    /// <summary>
    /// Runs every 1 minute
    /// </summary>
    public class TimerFunction
    {
        [FunctionName("TimerFunction")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
