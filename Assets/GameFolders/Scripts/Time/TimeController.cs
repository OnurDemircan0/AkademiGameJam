using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI time_Text;
    [SerializeField] float questionTime;

    public static float currentTime;

    public static float specifiedTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = questionTime;
        specifiedTime = questionTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (RiddleController.questionActive)
        {
            currentTime -= Time.deltaTime;
            currentTime = Mathf.Clamp(currentTime, 0, questionTime);
        }
        else
        {
            currentTime = questionTime;
        }

        time_Text.text = ((int)currentTime).ToString();

    }
}
