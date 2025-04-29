using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Container = Microsoft.Azure.Cosmos.Container;

namespace ProcessEventHub
{
    public static class ProcessMessage
    {

        private static readonly string _connection_string = "";
        private static readonly string _database_name = "logdb";
        private static readonly string _container_name = "weblogs";

        [FunctionName("ProcessMessage")]
        public static async Task Run([EventHubTrigger("log", Connection = "hubconnection")] EventData[] events, ILogger log)
        {
            var exceptions = new List<Exception>();

            CosmosClient _cosmosclient = new CosmosClient(_connection_string, new CosmosClientOptions());
            Container _container = _cosmosclient.GetContainer(_database_name, _container_name);

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
                                Weblog weblog = new Weblog();
                                weblog.id= Guid.NewGuid().ToString();
                                weblog.CIp = obj["properties"]["CIp"].ToString();
                                weblog.ScStatus = obj["properties"]["ScStatus"].ToString();
                                weblog.CsMethod = obj["properties"]["CsMethod"].ToString();
                                weblog.CsUriStem = obj["properties"]["CsUriStem"].ToString();
                                await _container.CreateItemAsync(weblog, new PartitionKey(weblog.CIp));
                        
                                Console.WriteLine("Item created");                                
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
