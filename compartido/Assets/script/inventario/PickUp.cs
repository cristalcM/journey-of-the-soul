using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class PickUp : MonoBehaviour
{


    //.................................


    playerinventory inventory;
    MostrarInformacionItem informacion;

    public ParticleSystem particle;
    public Sprite sprite;
    public ItemType type;
    public string nameitem;
    public string describcion;
    public string think;
   


    //TESTO A MOSTAR 
    public Text textoUI;
    




    // Start is called before the first frame update
    void Start()
    {
        
        //................
        inventory = playerinventory.instance;
        textoUI.enabled = false; // Aseguramos que el texto esté desactivado al inicio
    }
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            /// LO AGREGE 
            for (int i = 0; i < inventory.items.Length; i++)

            {
                if (inventory.items[i].isFull == false)
                {
                    Debug.Log("item añadido");
                    // Mostramos el texto
                    textoUI.enabled = true;
                    textoUI.text = think;

                    inventory.items[i].isFull = true;
                    inventory.items[i].amount = 1;
                    inventory.items[i].type = type;
                    inventory.items[i].name = nameitem;
                    inventory.items[i].think = think;
                    inventory.items[i].description = describcion;
                    inventory.items[i].spriteIMG = sprite;
                    inventory.items[i].slotsSprite.GetComponent<Image>().sprite = sprite;
                    inventory.items[i].slotsSprite.GetComponent<Image>().enabled = true;
                    Destroy(gameObject);
                    Instantiate(particle, transform.position, Quaternion.identity);
                    break;
                }
                if (inventory.items[i].isFull == true && inventory.items[i].name == nameitem && inventory.items[i].amount < 10)
                {
                    Debug.Log("itemStakeado");
                    inventory.items[i].amount += 1;
                    Destroy(gameObject);
                    Instantiate(particle, transform.position, Quaternion.identity);
                    break;
                }
               






            }




        }
      
    }
   
}



