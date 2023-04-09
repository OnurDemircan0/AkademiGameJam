using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator _animator;

    public static bool showPaper;
    public static bool replacePaper;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        showPaper = false;
        replacePaper = false;
    }

    private void Update()
    {
        if (showPaper)
        {
            _animator.SetBool("ReplacePaper", false);
            _animator.SetBool("ShowPaper", true);
        }
        else if (replacePaper)
        {
            _animator.SetBool("ShowPaper", false);
            _animator.SetBool("ReplacePaper", true);
        }
    }

}
