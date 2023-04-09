using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockVibrate : MonoBehaviour
{
    Animator _animator;

    public static bool canVibrate;

    // Start is called before the first frame update
    void Start()
    {
        canVibrate = false;

        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canVibrate)
        {
            canVibrate = false;
            Debug.Log("aþfþlakdgiladg");
            _animator.SetTrigger("Vibration");
        }
    }
}
