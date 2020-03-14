using Newtonsoft.Json;

public class GeoJsonTree
{

    public GeoJsonTree(int id,string name,string species,GeoJsonCollection collection)
    {
        Id = id;
        Name = name;
        Species = species;
        Collection = collection;
    }
    [JsonProperty("id")]
    public int Id{ get; set; }

    [JsonProperty("name")]
    public string Name{ get; set; }

    [JsonProperty("species")]
    public string Species{ get; set; }

    [JsonProperty("collection")]
    public GeoJsonCollection Collection { get; set; }
}
