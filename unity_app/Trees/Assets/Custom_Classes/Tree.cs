using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tree : MonoBehaviour
{
    //Used for local MonoBehavior
    public int Id;
    public string Name;
    public string Species;
    public GeoJsonCollection Collection;
    //end

    public static string stat_id;
    public static string stat_name;
    public static string stat_species;
    public static string treeDesc;


    //void update()
    // {

    //}
    /* static bool _display = false, hiding;
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
        GeoJsonTree jsonTree = new GeoJsonTree(Id,Name,Species,new GeoJsonCollection(1, new GeoJsonPosition(111, 222)));
        //Debug.Log(JsonConvert.SerializeObject(jsonTree));
        //content = "ID:" + Id + "\n" + "Name:" + Name + "\n" + "Species:" + Species;// + "\n" + Collection.Type + "\n" + Collection.Location;
        //_display = true;

        //save data to static to pass between scenes
        stat_id = Id.ToString();
        stat_name = Name;
        stat_species = Species;

        treeDesc = JsonConvert.SerializeObject(jsonTree);
        Debug.Log(treeDesc);
        SceneManager.LoadScene("Tree");

    }
}
