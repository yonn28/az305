using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace ProcessEventHub
{
    public static class ProcessMessage
    {
        [FunctionName("ProcessMessage")]
        public static async Task Run([EventHubTrigger("log", Connection = "hubconnection")] EventData[] events, ILogger log)
        {
            var exceptions = new List<Exception>();

                    // Replace these two lines with your processing logic.
                    foreach (EventData eventData in events)
                    {
                        try
                        {
                            string messageBody = Encoding.UTF8.GetString(eventData.EventBody);
                            JObject records = JObject.Parse(messageBody);

                            JArray jArray = JArray.Parse(records["records"].ToString());
                            var jObjects = jArray.ToObject<List<JObject>>();
                            foreach (var obj in jObjects)                             
                            {
                                Console.WriteLine(obj.ToString());
                            }

                                await Task.Yield();
                }
                catch (Exception e)
                {
                    // We need to keep processing the rest of the batch - capture this exception and continue.
                    // Also, consider capturing details of the message that failed processing so it can be processed again later.
                    exceptions.Add(e);
                }
            }

            // Once processing of the batch is complete, if any messages in the batch failed processing throw an exception so that there is a record of the failure.

            if (exceptions.Count > 1)
                throw new AggregateException(exceptions);

            if (exceptions.Count == 1)
                throw exceptions.Single();
        }
    }
}
