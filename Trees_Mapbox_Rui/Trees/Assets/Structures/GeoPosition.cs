public class GeoPosition
{
		public GeoPosition(double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}
		public double Altitude { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
}
