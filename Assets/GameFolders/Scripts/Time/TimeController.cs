using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI time_Text;
    [SerializeField] float questionTime;
    [SerializeField] Color32 timeFont;
    [SerializeField] Color32 timeFont2;

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

        if(currentTime < 4)
        {
            time_Text.color = timeFont2;
        }
        else
        {
            time_Text.color = timeFont;
        }

        time_Text.text = ((int)currentTime).ToString();

    }
}
