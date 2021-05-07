using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(PlayerMovement), typeof(PlayerJump))]

public class PlayerController : MonoBehaviour
{
    // Calling Referenced Components
    private PlayerControls controls;
    private PlayerMovement playerMove;
    private PlayerJump playerJump;

    // Creating Serialized Variables

    // Creating Component Variables
    private float jumpInput;
    private bool jumpState;

    private void Awake(){
        Application.targetFrameRate = 300;

        controls = new PlayerControls();
        playerMove = GetComponent<PlayerMovement>();
        playerJump = GetComponent<PlayerJump>();

        controls.Player.Movement.performed += ctx => Movement(ctx.ReadValue<Vector2>());
        controls.Player.Movement.canceled += ctx => Movement(Vector2.zero);

        controls.Player.Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
    }

    private void Update(){
        if (jumpInput > 0.5f){
            jumpState = true;
        }
        else if (jumpInput < 0.5f){
            jumpState = false;
        }
        Jumping(jumpState);
    }

    private void Movement(Vector2 moveInput){
        playerMove.Move(moveInput);
    }

    private void Jumping(bool jumpState){
        playerJump.Jump(jumpState);
    }

    private void Attacking(){
        
    }

    private void OnEnable(){
        controls.Player.Enable(); 
    }

    private void OnDisable(){
        controls.Player.Disable();
    }
}
