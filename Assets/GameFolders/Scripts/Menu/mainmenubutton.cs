using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenubutton : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }


    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}    

