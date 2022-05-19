using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerController playerController;
    private PlayerController.PlayerActions player;

    private Player_Movemment movement;


    void Awake()
    {
        playerController = new PlayerController();
        player = playerController.Player;
        movement = GetComponent<Player_Movemment>();
        player.Jump.performed += ctx => movement.Jump();
    }

    void FixedUpdate()
    {
        movement.ProcessMove(player.Move.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        player.Enable();
    }
    private void OnDisable()
    {
        player.Disable();
    }
}
