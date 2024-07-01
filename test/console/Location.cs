using System.Text.Json.Serialization;

public class Location
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set;}
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class AvailabilityZoneMapping
    {
        public string logicalZone { get; set; }
        public string physicalZone { get; set; }
    }

    public class Metadata
    {
        public string geography { get; set; }
        public string geographyGroup { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public List<PairedRegion> pairedRegion { get; set; }
        public string physicalLocation { get; set; }
        public string regionCategory { get; set; }
        public string regionType { get; set; }
    }

    public class PairedRegion
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Root
    {
        public List<AvailabilityZoneMapping> availabilityZoneMappings { get; set; }
        public string displayName { get; set; }
        public string id { get; set; }
        public Metadata metadata { get; set; }
        public string name { get; set; }
        public string regionalDisplayName { get; set; }
        public string type { get; set; }
    }

