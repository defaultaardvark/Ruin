using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Calling Referenced Components
    Rigidbody2D rigidBody;

    // Creating Serialized Variables

    // Creating Component Variables
    private bool grounded;
    private bool jumping;
    private Vector2 counterJumpForce;

    private bool jumpKey;
    private bool jumpKeyPrev = false;
    private float jumpForce;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
        jumpForce = CalculateJumpForce(Physics2D.gravity.magnitude, 5.0f);        
    }

    private void FixedUpdate(){
        if (jumpKey == true){
            if (grounded == true){
                rigidBody.AddForce(Vector2.up * jumpForce * rigidBody.mass, ForceMode2D.Impulse);
            }
        }
        
    }

    public static float CalculateJumpForce(float gravityStrength, float jumpHeight){
        // h = v^2/2g
        // 2gh = v^2
        // sqrt(2gh) = v
        return Mathf.Sqrt(2 * gravityStrength * jumpHeight);
    }

    public void Jump(bool jumpInput){
        // Debug.Log(jumpInput);
        jumpKey = jumpInput;
    }
}
