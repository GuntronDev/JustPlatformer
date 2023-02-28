using System;
using UnityEngine;

public class SpikesDamage_SC : MonoBehaviour
{
  void OnCollisionStay2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            Collision.gameObject.transform.position = new Vector2(SaveStation_Sc.LastSavePoint[0], SaveStation_Sc.LastSavePoint[1]);
        }
    }
    

}
