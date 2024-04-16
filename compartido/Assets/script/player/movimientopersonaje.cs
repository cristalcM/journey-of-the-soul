using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class movimientopersonaje : MonoBehaviour
{
    //inventario 
    public Item[] items;

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    public float speed = 5f;
    public float JumpForce = 250f;
    private float Velocidadvase = 5f;
    private bool Grounded;
    Vector2 dir;

    //...........................................................


    [Header("Animacion")]
    private Animator animator;


    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        //movimiento en z
        Horizontal = Input.GetAxisRaw("Horizontal") * Velocidadvase;
        if (Horizontal < 0) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
       
        //animacion
        animator.SetFloat("Horizontal" , Mathf.Abs(Horizontal));
        Rigidbody2D.AddForce(new Vector2(dir.x, 0) * speed * Time.deltaTime);

        //SALTITO UWU

        Debug.DrawRay(transform.position, Vector3.down * 0.8f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.8f))
        {
            Grounded = true;
        }
        else Grounded = false;

        animator.SetBool("enSUELO", Grounded);

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            savedata();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            loaddata();
        }

    }

    private void loaddata()
    {
        playerdata playerdata = SaveManajer.LoadPlayerData();
        items = playerdata.inventario;
        transform.position = new Vector3(playerdata.posicion[0], playerdata.posicion[1], playerdata.posicion[2]);
        Debug.Log("datos cargados uwu");
    }

    private void savedata()
    {
        SaveManajer.SavePlayerData(this);
        Debug.Log("guardado uwu");
    }


    //para saltar
    public  void Jump()
    {
       Rigidbody2D.AddForce(Vector2.up * JumpForce);

    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }


    //para moverse con josrtik
    public void movedir(Vector2 direction)
    {
        dir = direction;
    }



}
