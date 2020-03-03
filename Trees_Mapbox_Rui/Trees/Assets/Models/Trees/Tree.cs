using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GeoTree TreeInfo { get; set; }

    private void OnMouseDown()
    {
        Debug.Log(TreeInfo.Name);
    }
}
