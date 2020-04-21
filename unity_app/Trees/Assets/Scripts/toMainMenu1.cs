/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toMainMenu1
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. 
// *                     
/////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toMainMenu1 : MonoBehaviour
{

    public void toMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
