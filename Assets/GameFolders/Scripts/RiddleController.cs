using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RiddleController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI correctAnswers_Text;
    [SerializeField] GameObject question1, question2, question3;

    int correctAnswers;
    int questionNumber;

    private void Start()
    {
        correctAnswers = 0;
        questionNumber = 1;
    }

    private void Update()
    {
        if(questionNumber == 1)
        {
            question1.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A))
            {
                RightAnswer();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                WrongAnswer();
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                WrongAnswer();
            }
        }
        else if (questionNumber == 2)
        {
            question1.SetActive(false);
            question2.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A))
            {
                RightAnswer();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                WrongAnswer();
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                WrongAnswer();
            }
        }
        else if (questionNumber == 3)
        {
            question2.SetActive(false);
            question3.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A))
            {
                RightAnswer();
                question3.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                WrongAnswer();
                question3.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                WrongAnswer();
                question3.SetActive(false);
            }
        }
        
    }

    public void RightAnswer()
    {
        questionNumber++;
        correctAnswers++;
        correctAnswers_Text.text = correctAnswers.ToString();
    }

    public void WrongAnswer()
    {
        questionNumber++;
    }

}
