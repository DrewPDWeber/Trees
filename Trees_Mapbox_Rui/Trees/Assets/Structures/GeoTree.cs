using Newtonsoft.Json;

public class GeoTree
{
	[JsonProperty("id")] 
	public int Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("species")]
	public string Species { get; set; }

	[JsonProperty("geotype")]
	public GeoTypeInfo GeoType { get; set; }
}
