using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Tree : MonoBehaviour
{
    [JsonProperty("id")]
    public int Id;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("species")]
    public string Species;

    [JsonProperty("geotype")]
    public GeoTypeInfo GeoType;

    private void OnMouseDown()
    {
            Debug.Log(Name);
    }
}
