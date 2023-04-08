using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RivalCharacter : MonoBehaviour
{
    public float countdownLength = 10f;

    public KeyCode startkey = KeyCode.KeypadEnter;
    public KeyCode resetkey = KeyCode.R;

    public string[] options = { "A", "B", "C", "D" };
    public int optionsIndex = -1;

    public Animator animator;
    private bool CountingDown = false;
    private float Timer = 0f;

    


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


        optionsIndex = Random.Range(0, options.Length);


        animator.SetBool("Writing", true);
        animator.SetBool("Idle", false);
        animator.SetBool("ShowingAnswer", false);
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
        return options[optionsIndex];
    }
}
