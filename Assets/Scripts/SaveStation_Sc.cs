using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStation_Sc : MonoBehaviour
{
    public static float[] LastSavePoint = new float[2];
            
    void OnTriggerEnter2D(Collider2D Collision)
    {
        LastSavePoint[0] = gameObject.transform.position.x;
        LastSavePoint[1] = gameObject.transform.position.y;
    }

}
