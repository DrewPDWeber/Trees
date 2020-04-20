using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    
    public void FadeToScene()
    {
        animator.SetTrigger("FadeOut");
    }
}
