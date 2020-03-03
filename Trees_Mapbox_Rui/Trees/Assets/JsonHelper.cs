using Newtonsoft.Json;
using UnityEngine;

public class JsonHelper : MonoBehaviour
{
	public static string Decode(GeoTree myTree) //simple encodes to Json
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

	public GeoTree CreateTree(int id, string name, string species, GeoTypeInfo geoInfo)
	{
		return  new GeoTree
		{
			Id = id,
			Name = name,
			Species = species,
			GeoType = geoInfo
		};
	}
}
