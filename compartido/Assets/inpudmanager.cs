using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inpudmanager : MonoBehaviour
{
    private bool Grounded;
    Controls controls;
    private void Awake()
    {
        controls = new Controls();
    }

    private void Update()
    {
       
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.move.performed += movePlayer;
        controls.Gameplay.move.canceled += movePlayer;
        controls.Gameplay.Jump.started += jumpPlayer;
        
    }



    private void jumpPlayer(InputAction.CallbackContext conext)
    {
        FindObjectOfType<movimientopersonaje>().Jump();

    }

    
    private void movePlayer(InputAction.CallbackContext context)
    {
       Vector2 movedir = context.ReadValue<Vector2>();
        
        FindObjectOfType<movimientopersonaje>().movedir(movedir);

    }
}
