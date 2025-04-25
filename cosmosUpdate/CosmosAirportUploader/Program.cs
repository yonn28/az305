using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

class Program
{
    static async Task Main(string[] args)
    {
        string endpoint = "";
        string key = "";
        string databaseName = "flightDetails";
        string collectionName = "airportCodes";
        string jsonFilePath = "airports.json"; // Path to your JSON file

        CosmosClient client = new CosmosClient(endpoint, key);
        Container container = client.GetContainer(databaseName, collectionName);

        try
        {
            // Read and deserialize JSON file
            string jsonContent = await File.ReadAllTextAsync(jsonFilePath);
            var airports = JsonSerializer.Deserialize<List<Airport>>(jsonContent);

            if (airports != null)
            {
                foreach (var airport in airports)
                {
                    await container.CreateItemAsync(airport, new PartitionKey(airport.id));
                    Console.WriteLine($"Added airport: {airport.name} ({airport.id})");
                }
            }
        }
        catch (CosmosException ex)
        {
            Console.WriteLine($"Cosmos DB error: {ex.StatusCode} - {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Process completed.");
    }
}

public class Airport
{
    public string id { get; set; }
    public string icao { get; set; }
    public string iata { get; set; }
    public string name { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public int elevation { get; set; }
    public double lat { get; set; }
    public double lon { get; set; }
    public string tz { get; set; }
}
