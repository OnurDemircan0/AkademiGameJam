using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioSource ClickSound;

    public void playSound()
    {
        ClickSound.Play();
    }
}
