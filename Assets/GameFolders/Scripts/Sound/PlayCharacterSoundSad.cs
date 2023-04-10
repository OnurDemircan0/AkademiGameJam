using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCharacterSoundSad : MonoBehaviour
{
    AudioSource _characterAudio;

    // Start is called before the first frame update
    void Start()
    {
        _characterAudio = GetComponent<AudioSource>();
        _characterAudio.volume = PlayerPrefs.GetFloat("audioVolume");
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayCharacterSound.happy)
        {
            _characterAudio.enabled = true;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3f);
        _characterAudio.enabled = false;
    }
}
