using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Calling Referenced Components
    private Rigidbody2D rigidBody;

    // Creating Component Variables
    private float inputX;
    private float inputY;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movement Occurs Here
        rigidBody.velocity = new Vector2(inputX, rigidBody.velocity.y);
    }

    public void Move(float dirInputX, float dirInputY){
        inputX = dirInputX;
        inputY = dirInputY;
    }
}