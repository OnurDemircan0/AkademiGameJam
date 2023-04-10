using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerCorrectAnswersText, rivalCorrectAnswersText;
    [SerializeField] GameObject[] medals;

    int playerCorrectAnswers;
    int rivalCorrectAnswers;

    // Start is called before the first frame update
    void Start()
    {
        playerCorrectAnswers = PlayerPrefs.GetInt("playerCorrectAnswers", playerCorrectAnswers);
        rivalCorrectAnswers = PlayerPrefs.GetInt("rivalCorrectAnswers", rivalCorrectAnswers);

        playerCorrectAnswersText.text = playerCorrectAnswers.ToString();
        rivalCorrectAnswersText.text = rivalCorrectAnswers.ToString();

        if(playerCorrectAnswers == 1)
        {
            medals[0].SetActive(true);
        }
        else if (playerCorrectAnswers == 2)
        {
            medals[1].SetActive(true);
        }
        else if (playerCorrectAnswers == 3)
        {
            medals[2].SetActive(true);
        }
    }

}
