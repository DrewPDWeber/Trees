using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using Newtonsoft.Json;

public class TreeData : MonoBehaviour
{
    [SerializeField] private Text treeData;

    [JsonProperty("id")]
    public int Id;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("species")]
    public string Species;

    [JsonProperty("geotype")]
    public GeoTypeInfo GeoType;
    // Start is called before the first frame update
    void Start()
    {
        treeData.text = Id.ToString() + " " + Name + " " +Species;
    }
}
