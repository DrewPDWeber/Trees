using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Networking;
public class GoogleApi : MonoBehaviour
{
    public RawImage img;

    string url;

    public float lat;
    public float lon;

    LocationInfo li;

    public int zoom = 14;
    public int mapWidth = 640;
    public int mapHeight = 640;

    public enum mapType
    {
        rodmap, satellite, hybrid, 
    }

    public mapType mapSelected;

    public int scale;

    IEnumerator Map()
    {
        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
             "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale
             + "&maptype=" + mapSelected +
             "&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key= + AIzaSyALry_hyLGN7lYEyxIvlixZQZd09rbWnVs";
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }


    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<RawImage>();
        StartCoroutine(Map());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
