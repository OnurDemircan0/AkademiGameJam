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

    [SerializeField] bool gameLevel;

    public static float volume;

    private void Awake()
    {
        Current = this;

        level = PlayerPrefs.GetInt("level", level);
    }

    private void Start()
    {
        if (gameLevel)
        {
            levelText.text = "Level " + level;
        }
    }

    public void LoadScene()
    {
        if(level > 10)
        {
            level = 1;
            PlayerPrefs.SetInt("level", level);
        }
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

    public void SaveAudioVolume()
    {
        volume = MainMenuSound.audioVolume;
    }

}
