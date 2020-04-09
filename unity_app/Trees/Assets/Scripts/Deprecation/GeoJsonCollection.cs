using Newtonsoft.Json;
using UnityEngine;

public class GeoJsonCollection
{
	public GeoJsonCollection(int type,GeoJsonPosition pos)
	{
		Type = type;
		Location = pos;
	}

	[JsonProperty("type")] 
	public int Type { get; set; }

	[JsonProperty("location")] 
	public GeoJsonPosition Location { get; set; }
}


