using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimientopersonaje : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    public float speed = 5f;
    public float JumpForce = 250f;
    private float Velocidadvase = 5f;
    private bool Grounded;
  
    //...........................................................
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
     

    }

    void Update()
    {
        //movimiento en z
        Horizontal = Input.GetAxisRaw("Horizontal") * Velocidadvase;


        //SALTITO UWU

        Debug.DrawRay(transform.position, Vector3.down * 0.8f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.8f))
        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }


    }

   
    //para saltar
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }

   



}
