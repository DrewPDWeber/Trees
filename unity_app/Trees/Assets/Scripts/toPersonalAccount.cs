/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toPersonalAccount
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. 
// *                     
/////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toPersonalAccount : MonoBehaviour
{
    public void ToPersonalAccount()
    {
        SceneManager.LoadScene("PersonalAccount");
    }
}
