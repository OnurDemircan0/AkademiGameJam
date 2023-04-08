using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RivalCharacter : MonoBehaviour
{
    public float countdownLength = 10f;

    public KeyCode startkey = KeyCode.KeypadEnter;
    public KeyCode resetkey = KeyCode.R;

    public string[] optFalse = { "False1", "False2", "False3"};
    public string optTrue = "True";
    public int optionsIndex = -1;

    public Animator animator;
    private bool CountingDown = false;
    private float Timer = 0f;

    public string answer;

    public int diff = 0;

    


    void Start()
    {
        animator.SetBool("Idle", true);
        animator.SetBool("Writing", false);
        animator.SetBool("ShowingAnswer", false);
    }


    void Update()
    {

        if (CountingDown)
        {
            Timer -= Time.deltaTime;

            if (Timer <= 0f)
            {
                EndCountdown();
            }
        }

        else
        {
            if (Input.GetKeyDown(startkey))
            {
                StartCountdown();
            }
        }


        if (Input.GetKeyDown(resetkey))
        {
            ResetCharacter();
        }
    }


    void StartCountdown()
    {
        CountingDown = true;
        Timer = countdownLength;


        switch(LevelController.level)
        {
            case 1:
                //level 1

                optionsIndex = Random.Range(0, optFalse.Length);
                answer = optFalse[optionsIndex];
                diff += 5;
                break;

            case 2:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }
                    
                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }
                
                break;
            case 3:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

            case 4:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;
            case 5:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

            case 6:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

            case 7:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

            case 8:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

            case 9:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }
                break;

            case 10:
                if (Probability(diff))
                {
                    answer = optTrue;
                    diff += 5;
                }

                else
                {
                    optionsIndex = Random.Range(0, optFalse.Length);
                    answer = optFalse[optionsIndex];
                    diff += 5;
                }

                break;

        }


        animator.SetBool("Writing", true);
        animator.SetBool("Idle", false);
        animator.SetBool("ShowingAnswer", false);
    }

    static bool Probability(int probabilityValue)
    {
        int randomNumber = Random.Range(0, 100);
        

        if (randomNumber <= probabilityValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


void EndCountdown()
    {
    CountingDown = false;


        animator.SetBool("Writing", false);
        animator.SetBool("Idle", false);
        animator.SetBool("ShowingAnswer", true);
        
    }


    void ResetCharacter()
    {
        CountingDown = false;

        animator.SetBool("Idle", true);
        animator.SetBool("Writing", false);
        animator.SetBool("ShowingAnswer", false);
    }


    public string GetCurrentOption()
    {
        return answer;
    }
}
