using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerMovement), typeof(PlayerJump))]

public class PlayerController : MonoBehaviour
{
    // Calling Referenced Components
    private PlayerMovement movement;
    private PlayerJump jump;

    // Creating Serialized Variables
    [SerializeField] private float speed;

    // Creating Controller Variables
    private float inputX;
    private float inputY;

    private void Awake(){
        movement = GetComponent<PlayerMovement>();
        jump = GetComponent<PlayerJump>();
    }

    private void Start()
    {
        Application.targetFrameRate = 300;    
    }

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal") * (Time.deltaTime * speed);
        inputY = Input.GetAxis("Vertical") * (Time.deltaTime * speed);

        movement.Move(inputX, inputY);
        jump.Jump();

    }
}
