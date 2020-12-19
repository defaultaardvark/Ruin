using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Calling Referenced Components
    PlayerControls controls;
    PlayerMovement movement;

    // Creating Serialized Variables

    // Creating Controller Variables
    private Vector2 inputDir;

    private void Awake(){
        controls = new PlayerControls();
        controls.GamePlay.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GamePlay.Movement.canceled += ctx => move = Vector2.zero;
    }

    private void Start()
    {
        Application.targetFrameRate = 300;    
    }

    private void Update()
    {

    }

    private void Move{
        movement.Move();
    }

    private void OnEnable(){
        controls.GamePlay.Enable(); 
    }

    private void OnDisable(){
        controls.GamePlay.Disable();
    }
}
