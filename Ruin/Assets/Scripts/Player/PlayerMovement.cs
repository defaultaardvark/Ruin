using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Calling Referenced Components
    private Rigidbody2D rigidBody;

    // Creating Serialized Variables
    [SerializeField] private float speed;

    // Creating Movement Variables
    private float xInput;
    private float yInput;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        // Movement Occurs Here
        rigidBody.velocity = new Vector2(xInput * speed, 0);
    }

    public void Move(Vector2 dirInput){
        xInput = dirInput.x;
        yInput = dirInput.y;
    }
}