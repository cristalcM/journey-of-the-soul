using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;




public enum ItemType

{
    linterna,
    planta,
    pastillas,

}
public class playerinventory : MonoBehaviour
{ 
    public static playerinventory instance;
    public Item[] items;



    //ESTO ES PARA ABRIR EL INVENTARIO 
    public GameObject inventario;
    private bool inventarioavierto = false;
    


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
      inventario.SetActive(false);
    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            inventarioavierto = !inventarioavierto;
            inventario.SetActive(inventarioavierto);
        }
    }


    public void EmtySlot()
    {

    }
   

}
[System.Serializable]

public class Item
{

    public bool isFull;
    public int amount;
    public ItemType type;
    public string name;
    public string description;
    public string think;
    public GameObject slotsSprite;
    public Sprite spriteIMG;

}








