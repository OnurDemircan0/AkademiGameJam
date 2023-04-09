using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddles : MonoBehaviour
{
    public TextMeshPro question;
    public string[] childNames = { "A", "B", "C", "D" };

    private TextMeshPro[] childTextMeshes;

    private void Start()
    {
        TextMeshPro question = GetComponent<TextMeshPro>();
        childTextMeshes = new TextMeshPro[childNames.Length];
        for (int i = 0; i < childNames.Length; i++)
        {
            Transform childTransform = transform.Find(childNames[i]);
            if (childTransform != null)
            {
                childTextMeshes[i] = childTransform.GetComponent<TextMeshPro>();
            }
        }
    }

    private void Update()
    {

        switch (LevelController.level)
        {
            case 1:
                childTextMeshes[0].text = "A 1";
                break;

            case 2:
                childTextMeshes[0].text = "A 2";
                break;
            case 3:
                childTextMeshes[0].text = "A 3";
                break;
            case 4:
                childTextMeshes[0].text = "A 4";
                break;
            case 5:
                childTextMeshes[0].text = "A 5";
                break;
            case 6:
                childTextMeshes[0].text = "A 6";
                break;
            case 7:
                childTextMeshes[0].text = "A 7";
                break;
            case 8:
                childTextMeshes[0].text = "A 8";
                break;
            case 9:
                childTextMeshes[0].text = "A 9";
                break;
            case 10:
                childTextMeshes[0].text = "A 10";
                break;

        }

        switch (LevelController.level)
        {
            case 1:
                childTextMeshes[1].text = "B 1";
                break;

            case 2:
                childTextMeshes[1].text = "B 2";
                break;
            case 3:
                childTextMeshes[1].text = "B 3";
                break;
            case 4:
                childTextMeshes[1].text = "B 4";
                break;
            case 5:
                childTextMeshes[1].text = "B 5";
                break;
            case 6:
                childTextMeshes[1].text = "B 6";
                break;
            case 7:
                childTextMeshes[1].text = "B 7";
                break;
            case 8:
                childTextMeshes[1].text = "B 8";
                break;
            case 9:
                childTextMeshes[1].text = "B 9";
                break;
            case 10:
                childTextMeshes[1].text = "B 10";
                break;

        }

        switch (LevelController.level)
        {
            case 1:
                childTextMeshes[2].text = "C 1";
                break;

            case 2:
                childTextMeshes[2].text = "C 2";
                break;
            case 3:
                childTextMeshes[2].text = "C 3";
                break;
            case 4:
                childTextMeshes[2].text = "C 4";
                break;
            case 5:
                childTextMeshes[2].text = "C 5";
                break;
            case 6:
                childTextMeshes[2].text = "C 6";
                break;
            case 7:
                childTextMeshes[2].text = "C 7";
                break;
            case 8:
                childTextMeshes[2].text = "C 8";
                break;
            case 9:
                childTextMeshes[2].text = "C 9";
                break;
            case 10:
                childTextMeshes[2].text = "C 10";
                break;

        }

        switch (LevelController.level)
        {
            case 1:
                childTextMeshes[3].text = "D 1";
                break;

            case 2:
                childTextMeshes[3].text = "D 2";
                break;
            case 3:
                childTextMeshes[3].text = "D 3";
                break;
            case 4:
                childTextMeshes[3].text = "D 4";
                break;
            case 5:
                childTextMeshes[3].text = "D 5";
                break;
            case 6:
                childTextMeshes[3].text = "D 6";
                break;
            case 7:
                childTextMeshes[3].text = "D 7";
                break;
            case 8:
                childTextMeshes[3].text = "D 8";
                break;
            case 9:
                childTextMeshes[3].text = "D 9";
                break;
            case 10:
                childTextMeshes[3].text = "D 10";
                break;

        }

        switch (LevelController.level)
        {
            case 1:
                question.text = "Question 1";
                break;
            case 2:
                question.text = "Question 2";
                break;
            case 3:
                question.text = "Question 3";
                break;
            case 4:
                question.text = "Question 4";
                break;
            case 5:
                question.text = "Question 5";
                break;
            case 6:
                question.text = "Question 6";
                break;
            case 7:
                question.text = "Question 7";
                break;
            case 8:
                question.text = "Question 8";
                break;
            case 9:
                question.text = "Question 9";
                break;
            case 10:
                question.text = "Question 10";
                break;
        }


    }

}
