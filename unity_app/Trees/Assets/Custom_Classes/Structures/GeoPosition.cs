using Newtonsoft.Json;

public class GeoPosition
{
		public GeoPosition(double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}

		[JsonProperty("altitude")]
		public double Altitude { get; set; }
		
		[JsonProperty("latitude")]
		public double Latitude { get; set; }
		[JsonProperty("longitude")]
		public double Longitude { get; set; }
}
