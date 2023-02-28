using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoventSC : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float PlayerSpeed;
    [SerializeField] private float PlayerJumpForce = 10;
    private float PlayerAxis;
    // Start is called before the first frame update

    void FixedUpdate()
    {
        PlayerMovement();
        //ask if can jump
        
    }
    void Update()
    {
        if (Input.GetKeyDown("space") && GroundCheck.HittingGround == true)
        {
            PlayerJump();
        }
    }

    private void PlayerMovement (){
        PlayerAxis = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(PlayerAxis * PlayerSpeed, rb.velocity.y);
    }

    private void PlayerJump()
    {
        rb.AddForce(transform.up * PlayerJumpForce,ForceMode2D.Impulse);
    }

}
