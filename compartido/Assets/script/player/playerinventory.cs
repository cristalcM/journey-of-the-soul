using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.IO;



public class playerinventory : MonoBehaviour
{
    public static playerinventory instance;
    public Item[] items;

    //ESTO ES PARA ABRIR EL INVENTARIO 
    public GameObject inventario;
    private bool inventarioAbierto = false;

    //private string filePath;

    private void Awake()
    {
        instance = this;
        //filePath = Application.persistentDataPath + "/inventory.json";
    }

    void Start()
    {
        inventario.SetActive(false);
        //LoadInventory();
        ////StartCoroutine(SavePeriodically());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventarioAbierto = !inventarioAbierto;
            inventario.SetActive(inventarioAbierto);
        }
    }

    public void EmtySlot()
    {
    }

    //public void SaveInventory()
    //{
    //    string json = JsonUtility.ToJson(this);
    //    File.WriteAllText(filePath, json);
    //}

    //public void LoadInventory()
    //{
    //    if (File.Exists(filePath))
    //    {
    //        string json = File.ReadAllText(filePath);
    //        JsonUtility.FromJsonOverwrite(json, this);
    //    }
    //}
    //IEnumerator SavePeriodically()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(60); // Esperar 60 segundos
    //        SaveInventory(); // Guardar los datos del inventario
    //    }
    //}
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

public enum ItemType
{
    linterna,
    planta,
    pastillas,
    foto,
    abecedario,
    radio,
    calabera,
    carta,
}


