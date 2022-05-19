using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class PlayerJump : MonoBehaviour
{
    private CharacterController characterController;

    private Vector3 playerVelocity;

    private bool groundedPlayer;

    // Jump Variáveis

    [SerializeField]private float jumpHeight = 5.0f;

    private bool jumpPressed = false;

    private float gravityValue = -9.81f;
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementJump();
    }

    void MovementJump()
    {
        groundedPlayer = characterController.isGrounded;

        // se tiver no chão para o movimento vertical
        if (groundedPlayer)
        {
            playerVelocity.y = 0.0f;
        }
        //se ativar o jum e o player estiver no choa o player salta
        if (jumpPressed && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight *-1.0f * gravityValue);
            jumpPressed = false;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }

    void OnJump()
    {
       if (characterController.velocity.y == 0) {
            jumpPressed = true;
            
        } else
        {
           
        }
    }
}
