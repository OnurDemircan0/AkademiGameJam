using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitOutController : MonoBehaviour
{
    Animator _animator;

    public static bool spitOut;

    // Start is called before the first frame update
    void Start()
    {
        spitOut = false;

        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spitOut)
        {
            _animator.SetBool("SpitOut", true);
        }
    }
}
