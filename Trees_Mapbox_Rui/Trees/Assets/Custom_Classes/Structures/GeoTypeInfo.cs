using Newtonsoft.Json;
using UnityEngine;

public class GeoTypeInfo
{
	public GeoTypeInfo(int type,GeoPosition pos)
	{
		Type = type;
		GeoLocation = pos;
	}

	[JsonProperty("type")] 
	public int Type { get; set; }

	[JsonProperty("geolocation")] 
	public GeoPosition GeoLocation { get; set; }
}


