using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool HittingGround = false;
        void OnTriggerStay2D(Collider2D Collision)
        {
            if (Collision.tag == "Ground")
            {       
                HittingGround = true;
            }
        }
        void OnTriggerExit2D(Collider2D Collision)
        {
            if (Collision.tag == "Ground")
            {
                HittingGround = false;
            }
        }
    
}
