using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
    public static LevelController Current;
    public static int level = 1;

    [SerializeField] TextMeshProUGUI levelText;

    private void Awake()
    {
        Current = this;
    }

    private void Start()
    {
        levelText.text = "Level " + level;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Level " + (level - 1));
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
