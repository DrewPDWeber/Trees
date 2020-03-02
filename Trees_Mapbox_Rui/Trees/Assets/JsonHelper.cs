using Newtonsoft.Json;
using UnityEngine;

public class JsonHelper : MonoBehaviour
{
	public static string Decode(Tree myTree) //simple encodes to Json
	{
		string json = JsonConvert.SerializeObject(myTree);
		Debug.Log("GeoTree object decoded \n");
		Debug.Log(json);
		return json;
	}

	public GeoTree Encode(string geoString)
	{
		Debug.Log("GeoTree Json encoded to Object\n");
		return JsonConvert.DeserializeObject<GeoTree>(geoString);
	}

	public GeoTree CreateTree(int id, string name, string species, GeoTypeInfo geoTyp, GeoPosition geoPosition)
	{
		return  new GeoTree
		{
			Id = 1,
			Name = "My first Tree",
			Species = "Potato",
			GeoType = new GeoTypeInfo() {Type = 2, GeoLocation = geoPosition}
		};
	}
}
