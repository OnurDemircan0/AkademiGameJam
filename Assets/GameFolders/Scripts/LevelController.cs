using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController Current;
    public static int level = 1;

    private void Awake()
    {
        Current = this;
    }

    public void CongratsMenu()
    {
        SceneManager.LoadScene("congrats");
    }

    public void GameOverMenu()
    {
        SceneManager.LoadScene("gameover");
    }

}
