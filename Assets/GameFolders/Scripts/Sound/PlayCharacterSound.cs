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
        _characterAudio.volume = PlayerPrefs.GetFloat("audioVolume");
    }

    // Update is called once per frame
    void Update()
    {
        if (happy)
        {
            _characterAudio.enabled = true;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3f);
        happy = false;
        _characterAudio.enabled = false;
    }
}
