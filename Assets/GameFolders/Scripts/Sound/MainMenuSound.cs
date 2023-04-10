using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuSound : MonoBehaviour
{
    Slider _slider;

    [SerializeField] AudioSource mainMenuAudio;

    public static float audioVolume;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = mainMenuAudio.volume;
    }

    // Update is called once per frame
    void Update()
    {
        mainMenuAudio.volume = _slider.value;
        audioVolume = _slider.value;
    }
}
