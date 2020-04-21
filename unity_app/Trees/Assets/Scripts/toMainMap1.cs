/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toMainMap1
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. 
// *                     
/////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMainMap1 : MonoBehaviour
{
    public void toMap()
    {
        SceneManager.LoadScene("World");
    }
}