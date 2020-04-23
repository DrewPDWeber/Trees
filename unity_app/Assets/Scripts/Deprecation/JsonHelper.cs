///////////////////////////////////////////////////////////////////////////////
//                   
// Title:            JsonHelper
//
// Author:           Drew Weber
// Description :     deprecated, use MongoDBManager   
//
///////////////////////////////////////////////////////////////////////////////
using Newtonsoft.Json;
using UnityEngine;

public class JsonHelper
{
	public static string Decode(GeoJsonTree myTree) //simple encodes to Json
	{
		string json = JsonConvert.SerializeObject(myTree);
		Debug.Log("GeoTree object decoded \n");
		Debug.Log(json);
		return json;
	}

	public static GeoJsonTree Encode(string geoString)
	{
		Debug.Log("GeoTree Json encoded to Object\n");
		return JsonConvert.DeserializeObject<GeoJsonTree>(geoString);
	}
 
}
