using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCharacterSoundSad : MonoBehaviour
{
    AudioSource _characterAudio;

    public static bool sad;

    // Start is called before the first frame update
    void Start()
    {
        _characterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sad)
        {
            _characterAudio.enabled = true;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        sad = false;
        _characterAudio.enabled = false;
    }
}
