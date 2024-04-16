using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum ItemTypeguar

{
    linterna,
    planta,
    pastillas,

}
public class MostrarInformacionItem : MonoBehaviour
{
    public static MostrarInformacionItem instance;
    public ItemGuardado[] itemG;


    // Método que se llama cuando se cierra la ventana de información
   
}
[System.Serializable]

public class ItemGuardado
{
    private ItemGuardado itemGuar;
    public Text descripcionText;

    public bool isFull;
    public int amount;
    public ItemType type;
    public string name;
    public string description;
    public string think;
    public GameObject slotsSprite;
    public Sprite spriteIMG;



    // Método que se llama cuando se hace clic en la imagen del ítem
    public void MostrarInformacion()
    {
        
        if (itemGuar != null)
        {
            descripcionText.text = "Nombre: " + name + "\n" +
                                "Descripción: " + description+ "\n" +
                                "Tipo: " + type.ToString() + "\n" +
                                "Cantidad: " +amount;
        }
    }
    public void CerrarInformacion()
    {
       itemGuar = null;
       descripcionText.text = "";
    }
   
}
