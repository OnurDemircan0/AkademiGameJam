using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RiddleController : MonoBehaviour
{
    [SerializeField] int rightAnswerQuestion1, rightAnswerQuestion2, rightAnswerQuestion3;

    [SerializeField] TextMeshProUGUI correctAnswers_Text, rivalCorrectAnswers_Text;
    [SerializeField] GameObject question1, question2, question3;

    private GameObject currentQuestion;

    [SerializeField] GameObject aIsTrue, bIsTrue, cIsTrue;
    private GameObject currentOptions;

    [SerializeField] GameObject playerChoiceA, playerChoiceB, playerChoiceC;
    [SerializeField] GameObject rivalChoiceA, rivalChoiceB, rivalChoiceC;

    [SerializeField] GameObject[] happyEmojis;
    [SerializeField] GameObject[] sadEmojis;

    [SerializeField] GameObject spitOutPaper;
    [SerializeField] GameObject splash;

    GameObject currentPlayerChoice;
    GameObject rightRivalChoice;
    GameObject wrongRivalChoice;
    

    bool playerAnswered;
    bool answerIsCorrect;

    int correctAnswers;
    int rivalCorrectAnswers;
    int maxRivalCorrectAnswers;
    int questionNumber;

    int rivalWinPossibility;

    bool showQuestion;
    public static bool questionActive;

    bool timePassed;

    private void Start()
    {
        correctAnswers = 0;
        rivalCorrectAnswers = 0;
        maxRivalCorrectAnswers = 2;
        questionNumber = 1;

        rivalWinPossibility = (LevelController.level - 1) * 8;
        rivalWinPossibility = Mathf.Clamp(rivalWinPossibility, 0, 100);

        playerAnswered = false;
        answerIsCorrect = false;

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

            if (!playerAnswered)
            {
                WrongAnswer();
                playerAnswered = false;
            }

            ClockVibrate.canVibrate = true;

            PlayerAnimation.replacePaper = false;
            PlayerAnimation.showPaper = true;

            int randomNumber = Random.Range(0, 100);

            //rivalCorrectAnswers eðer oyuncu yanlýþ cevap vermediyse en fazla 2 olabilir ki 3-3 lük bir durum saðlanamasýn. Oyuncu yanlýþ cevap verdiyse en fazla 3 olabiliyor.
            if(randomNumber <= rivalWinPossibility && rivalCorrectAnswers < maxRivalCorrectAnswers)
            {
                rivalCorrectAnswers++;
                rightRivalChoice.SetActive(true);
            }
            else
            {
                wrongRivalChoice.SetActive(true);
            }

            correctAnswers_Text.text = correctAnswers.ToString();
            rivalCorrectAnswers_Text.text = rivalCorrectAnswers.ToString();

            //Shows what the right answer.
            currentOptions.SetActive(true);

            if(currentPlayerChoice != null)
            {
                currentPlayerChoice.SetActive(true);
            }

            questionNumber++;

            if (answerIsCorrect)
            {
                for (int i = 0; i < happyEmojis.Length; i++)
                {
                    StartCoroutine(EmojiDelay(happyEmojis[i]));
                }
            }
            else
            {
                for (int i = 0; i < sadEmojis.Length; i++)
                {
                    StartCoroutine(EmojiDelay(sadEmojis[i]));
                }
            }

            Invoke(nameof(ReplaceQuestion), 2f);
        }

    }

    void LoadCongratsMenu()
    {
        LevelController.Current.CongratsMenu();
    }

    void LoadGameOverMenu()
    {
        LevelController.Current.GameOverMenu();
    }

    void ShowQuestionTrue()
    {
        showQuestion = true;
    }

    IEnumerator EmojiDelay(GameObject emoji)
    {
        emoji.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        emoji.SetActive(false);
    }

    void ReplaceQuestion()
    {
        questionActive = false;
        timePassed = false;
        currentQuestion.SetActive(false);
        currentOptions.SetActive(false);

        rightRivalChoice.SetActive(false);
        wrongRivalChoice.SetActive(false);

        if(currentPlayerChoice != null)
        {
            currentPlayerChoice.SetActive(false);
        }
        currentPlayerChoice = null;

        PlayerAnimation.showPaper = false;
        PlayerAnimation.replacePaper = true;
        
        if(questionNumber > 3)
        {
            if(correctAnswers > rivalCorrectAnswers)
            {
                Invoke(nameof(LoadCongratsMenu), 2.0f);
            }
            else
            {
                SpitOutController.spitOut = true;
                StartCoroutine(SpitOutDelay());
                //Invoke(nameof(SpitOutPaperDelay), 0.3f);
                Invoke(nameof(LoadGameOverMenu), 4.0f);
            }
            
        }
        else
        {
            Invoke(nameof(ShowQuestionTrue), 2.0f);
        }
    }

    IEnumerator SpitOutDelay()
    {
        yield return new WaitForSeconds(0.3f);
        spitOutPaper.SetActive(true);
        yield return new WaitForSeconds(0.23f);
        splash.SetActive(true);
    }
    /*
    void SpitOutPaperDelay()
    {
        spitOutPaper.SetActive(true);
    }
    */
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

            currentPlayerChoice = playerChoiceA;
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

            currentPlayerChoice = playerChoiceB;
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

            currentPlayerChoice = playerChoiceC;
        }

        if(rightAnswer == 0)
        {
            currentOptions = aIsTrue;
            rightRivalChoice = rivalChoiceA;

            int randomWrongChoice = Random.Range(0, 2);

            if (randomWrongChoice == 0)
            {
                wrongRivalChoice = rivalChoiceB;
            }
            else
            {
                wrongRivalChoice = rivalChoiceC;
            }
        }
        else if(rightAnswer == 1)
        {
            currentOptions = bIsTrue;
            rightRivalChoice = rivalChoiceB;

            int randomWrongChoice = Random.Range(0, 2);

            if (randomWrongChoice == 0)
            {
                wrongRivalChoice = rivalChoiceA;
            }
            else
            {
                wrongRivalChoice = rivalChoiceC;
            }
        }
        else if(rightAnswer == 2)
        {
            currentOptions = cIsTrue;
            rightRivalChoice = rivalChoiceC;

            int randomWrongChoice = Random.Range(0, 2);

            if (randomWrongChoice == 0)
            {
                wrongRivalChoice = rivalChoiceA;
            }
            else
            {
                wrongRivalChoice = rivalChoiceB;
            }
        }
    }
    
    void RightAnswer()
    {
        playerAnswered = true;
        showQuestion = false;
        answerIsCorrect = true;
        TimeController.currentTime = 0;
        correctAnswers++;
    }

    void WrongAnswer()
    {
        playerAnswered = true;
        showQuestion = false;
        answerIsCorrect = false;
        TimeController.currentTime = 0;
        maxRivalCorrectAnswers = 3;
    }


}
