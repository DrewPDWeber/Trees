using Newtonsoft.Json;
using UnityEngine;

public class JsonEncoder : MonoBehaviour
{
	// Start is called before the first frame update

	public class Tree
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Species { get; set; }
		public GeoTypeInfo GeoType { get; set; }
	}

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

	public class GeoTypeInfo
	{
		public int Type { get; set; }
		public GeoPosition GeoLocation { get; set; }
	}

	void Start()
	{
		var geoPoint = new GeoPosition(50.67072379029327, -120.3656365079346);


		Tree myTree = new Tree()
		{
			Id = 1,
			Name = "My first Tree",
			Species = "Potato",
			GeoType = new GeoTypeInfo()
			{
				Type = 2,
				GeoLocation = geoPoint
			}
		};

		string json = JsonConvert.SerializeObject(myTree);


		Debug.Log("The Json is /n");
		Debug.Log(json);



	}

	// Update is called once per frame
	void Update()
	{

	}
}