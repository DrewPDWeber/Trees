﻿/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            toDailyChallenge
// *
// * Authors:          Michael O'Neill
// * Description:      Move to a different scene. 
// *                     
/////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toDailyChallenge: MonoBehaviour
{
    public void toDailyChall()
    {
        SceneManager.LoadScene("DailyChallenge");
    }
}
