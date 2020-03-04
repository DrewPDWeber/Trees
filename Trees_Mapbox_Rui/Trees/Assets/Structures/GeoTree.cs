using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class GeoTree : MonoBehaviour
{
	[JsonProperty("id")] 
	public int Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("species")]
	public string Species { get; set; }

	[JsonProperty("geotype")]
	public GeoTypeInfo GeoType { get; set; }

    private void OnMouseDown()
    {
        if (Name != null)
            Debug.Log(Name);
        else
            Debug.Log("No tree");
    }
}
