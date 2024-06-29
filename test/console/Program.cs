using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string json = @"[
    {
        ""name"": ""eastus"",
        ""description"": ""East US""
    },
    {
        ""name"": ""westus"",
        ""description"": ""West US""
    }
]";

// Create an instance of HttpClient
// using (HttpClient client = new HttpClient())
// {
    // // Download the JSON file
    // string json = await client.GetStringAsync("https://example.com/your-json-file.json");

    // Deserialize the JSON into an array of AzureLocations.cs
    Location[] locations = JsonConvert.DeserializeObject<Location[]>(json);

    // Use the deserialized data
    foreach (Location location in locations)
    {
        Console.WriteLine($"Name: {location.Name}, Description: {location.Description}");
    }
