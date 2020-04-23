/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            LevelChanger
// *
// * Authors:          Michael O'Neill
// * Description:      Provide unity scene change methods for animation event to trigger after transition fade
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
using System.Threading; // // // 

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
       

    public void FadeToScene()
    {
        animator.SetTrigger("FadeOut");
               
    }
    // // // // // // // // // // // // // 
     // // // // // // // // // // // // //

    public void toMenu()
    {
       SceneManager.LoadScene("MainMenu");
    }

    public void toMap()
    {
       SceneManager.LoadScene("World");
    }

    public void ToTreeAccount()
    {
        SceneManager.LoadScene("Tree");
    }

    public void toDailyChall()
    {
        SceneManager.LoadScene("DailyChallenge");
    }

    public void ToPersonalAccount()
    {
        SceneManager.LoadScene("PersonalAccount");
    }
}


