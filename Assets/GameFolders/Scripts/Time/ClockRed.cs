using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockRed : MonoBehaviour
{
    Image _redImage;

    private void Start()
    {
        _redImage = GetComponent<Image>();
    }

    void Update()
    {
        _redImage.fillAmount = 1 - (TimeController.currentTime / TimeController.specifiedTime);

    }
}
