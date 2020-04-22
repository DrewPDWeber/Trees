/////////////////////////////////////////////////////////////////////////////////////
// *                 
// * Title:            Sinigleton
// *
// * Authors:          Rui Wang
// * Description:      Singleton pattern class. This class detects if T is a 
// *                   MonoBehavior and will make a containing GameObject.
// *                     
/////////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private T instance;

    public T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
            }
            DontDestroyOnLoad(gameObject);
            return instance;
        }
    }
}
