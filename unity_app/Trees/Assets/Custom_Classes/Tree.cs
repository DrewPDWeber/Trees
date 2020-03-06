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
    private void OnMouseDown()
    {
        Debug.Log("ID:" + Id);
        Debug.Log("Name:" + Name);
        Debug.Log("Species:" + Species);
        Debug.Log("Geotype:" + GeoType);
        content = "ID:" + Id + "\n" + "Name:" + Name + "\n" + "Species:" + Species + "\n";
        _display = true;
    }
}
