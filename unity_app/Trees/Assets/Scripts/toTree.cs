/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toTree
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. 
// *                     
/////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTree : MonoBehaviour
{
    public void ToTreeAccount()
    {
        SceneManager.LoadScene("Tree");
    }
}
