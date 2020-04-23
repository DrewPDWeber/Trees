/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toMainMenu1
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. Trigger transition fade sequence
// *                     
/////////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Threading;

public class toMainMenu1 : MonoBehaviour
{
    
    public Animator animator;

    public void FadeToScene()
    {
        animator.SetTrigger("FadeOut");
    }

    public void toMenu()
    {
        Delay delay = new Delay(1.0f);
        if (delay.IsReady)
        {
            SceneManager.LoadScene("MainMenu");

            // re-schedule for 1 more seconds in the future
            //delay.Reset();
        }
    }


 
    
}
