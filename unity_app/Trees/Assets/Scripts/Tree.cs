using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MongoDB.Driver.GeoJsonObjectModel;

public class Tree : MonoBehaviour
{
    //Used for local MonoBehavior
    public int Id;
    public string Name;
    public string Species;
    public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location;
    //end

    public static string stat_id;
    public static string stat_name;
    public static string stat_species;
    public static string treeDesc;

    public Material clicked;            // new material for the tree

    /*
    static bool _display = false, hiding;
    static string content;

    static Rect windowRect = new Rect(20, 20, 200, 200);
    const float time = 5f; //Seconds to read the text

    IEnumerator Hide()
    {
        if (!hiding)
        {
                 hiding = true;
                 yield return new WaitForSeconds(time);
                 hiding = false;
                 _display = false;
        }
        yield return null;
    }

    void OnGUI()
    {
        if (!_display)
            return;

        windowRect = GUI.Window(0, windowRect, DoMyWindow, content);

        StartCoroutine("Hide");
    }

    void DoMyWindow(int windowID)
    {
        GUI.DragWindow(new Rect(0, 0, 10000, 20));
    }
    */
    private void OnMouseDown()
    { 
        //Create GeoJsonTree
        GeoTree jsonTree = new GeoTree(Name,Species,new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(22,22)));
        //Debug.Log(JsonConvert.SerializeObject(jsonTree));
        //content = "ID:" + Id + "\n" + "Name:" + Name + "\n" + "Species:" + Species;// + "\n" + Collection.Type + "\n" + Collection.Location;
        //_display = true;

        //save data to static to pass between scenes
        stat_id = Id.ToString();
        stat_name = Name;
        stat_species = Species;

        treeDesc = JsonConvert.SerializeObject(jsonTree);
        Debug.Log(treeDesc);
        //SceneManager.LoadScene("Tree");       // Changing scenes will initiate all tree again, so I comment this line for testing. Still have error poping out when the scene changed. -- by Rui

        // The asset change is based on the click events just for now because we don't have database to offer the visit record. The asset of the tree will be reset when the scene change.  -- by Rui
        // For the real use case, changeAsset should be called during the loading based on the visit record. So it won't be reset when the scene change. -- by Rui
        changeAsset();
    }

    // changing the material of the tree
    private void changeAsset()
    {
        // Debug.Log(gameObject.name);
        gameObject.GetComponent<MeshRenderer>().material = clicked;
    }
}
