using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Calling Referenced Components
    private Rigidbody2D rigidBody;

    // Creating Component Variables

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movement Occurs Here
    }

    public void Move(float dirInputX, float dirInputY){
    }
}