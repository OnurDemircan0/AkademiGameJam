using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCharacterSound : MonoBehaviour
{
    AudioSource _characterAudio;

    public static bool happy;

    // Start is called before the first frame update
    void Start()
    {
        happy = false;

        _characterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (happy)
        {
            _characterAudio.enabled = true;
            StartCoroutine(Delay());
        }
        Debug.Log(happy);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        happy = false;
        _characterAudio.enabled = false;
    }
}
