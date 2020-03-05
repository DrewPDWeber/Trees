using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    private void Awake()
    {
        Assert.IsNotNull(menu);
    }

    public void OnClick()
    {
        toggleMenu();
    }
    
    public void toggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
