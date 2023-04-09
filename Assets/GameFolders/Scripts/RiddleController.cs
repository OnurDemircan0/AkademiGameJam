using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RiddleController : MonoBehaviour
{
    [SerializeField] int rightAnswerQuestion1, rightAnswerQuestion2, rightAnswerQuestion3;

    [SerializeField] TextMeshProUGUI correctAnswers_Text;
    [SerializeField] GameObject question1, question2, question3;

    private GameObject currentQuestion;

    [SerializeField] GameObject aIsTrue, bIsTrue, cIsTrue;
    private GameObject currentOptions;
    

    bool playerAnswered;

    int correctAnswers;
    int questionNumber;

    bool showQuestion;
    public static bool questionActive;

    bool timePassed;

    private void Start()
    {
        correctAnswers = 0;
        questionNumber = 1;

        playerAnswered = false;

        showQuestion = false;
        questionActive = false;

        timePassed = false;

        Invoke(nameof(ShowQuestionTrue), 3.0f);
    }

    //seri bir þekilde doðru cevaba týklayýnca correctAnswers sürekli olarak artabilir onu kontrol et.


    private void Update()
    {
        if (showQuestion)
        {
            questionActive = true;
            if (questionNumber == 1)
            {
                question1.SetActive(true);
                currentQuestion = question1;
                SelectRightAnswer(rightAnswerQuestion1);

            }
            else if (questionNumber == 2)
            {
                question2.SetActive(true);
                currentQuestion = question2;
                SelectRightAnswer(rightAnswerQuestion2);
            }
            else if (questionNumber == 3)
            {
                question3.SetActive(true);
                currentQuestion = question3;
                SelectRightAnswer(rightAnswerQuestion3);
            }
            else
            {
                question3.SetActive(false);
            }
        }

        if(TimeController.currentTime == 0 && !timePassed)
        {
            timePassed = true;

            ClockVibrate.canVibrate = true;

            if (!playerAnswered)
            {
                WrongAnswer();
            }
            PlayerAnimation.replacePaper = false;
            PlayerAnimation.showPaper = true;

            correctAnswers_Text.text = correctAnswers.ToString();

            //Shows what the right answer.
            currentOptions.SetActive(true);

            Invoke(nameof(ReplaceQuestion), 2f);
        }

    }



    void ShowQuestionTrue()
    {
        showQuestion = true;
    }


    void ReplaceQuestion()
    {
        questionActive = false;
        timePassed = false;
        currentQuestion.SetActive(false);
        currentOptions.SetActive(false);

        PlayerAnimation.showPaper = false;
        PlayerAnimation.replacePaper = true;
        Invoke(nameof(ShowQuestionTrue), 2.0f);
    }

    void SelectRightAnswer(int rightAnswer)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (rightAnswer == 0)
            {
                
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (rightAnswer == 1)
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (rightAnswer == 2)
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }

        if(rightAnswer == 0)
        {
            currentOptions = aIsTrue;
        }
        else if(rightAnswer == 1)
        {
            currentOptions = bIsTrue;
        }
        else if(rightAnswer == 2)
        {
            currentOptions = cIsTrue;
        }
    }
    
    void RightAnswer()
    {
        Debug.Log("1");
        playerAnswered = true;
        showQuestion = false;
        TimeController.currentTime = 0;
        questionNumber++;
        correctAnswers++;
        
    }

    void WrongAnswer()
    {
        Debug.Log("2");
        playerAnswered = true;
        showQuestion = false;
        TimeController.currentTime = 0;
        questionNumber++;
    }

}
