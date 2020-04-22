/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toTree
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

public class toTree : MonoBehaviour
{
    public Animator animator;

    public void FadeToScene()
    {
        animator.SetTrigger("FadeOutTree");
    }

    public void ToTreeAccount()
    {
        Delay delay = new Delay(1.0f);
        if (delay.IsReady)
        {
            SceneManager.LoadScene("Tree");

            // re-schedule for 1 more seconds in the future
            //delay.Reset();
        }
        
    }
}
