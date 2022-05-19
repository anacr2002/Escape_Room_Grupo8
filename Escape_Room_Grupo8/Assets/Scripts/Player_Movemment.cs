using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class Player_Movemment : MonoBehaviour
{
    private CharacterController characterController;
    private float speed = 5.0f;
    private Vector2 playerMovementInput;
   
    void Start()
    {
       
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        Vector3 movement = new Vector3(playerMovementInput.x, 0.0f, playerMovementInput.y);
        characterController.SimpleMove(movement * speed);
    }

    void OnMove (InputValue iv)
    {
        Debug.Log("Player a dar caralho");
        playerMovementInput = iv.Get<Vector2>();
    }
}
