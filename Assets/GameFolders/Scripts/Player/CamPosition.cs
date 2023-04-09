using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosition : MonoBehaviour
{
    public Transform playerHead;

    void LateUpdate()
    {
        transform.position = playerHead.position;
        
    }

}
