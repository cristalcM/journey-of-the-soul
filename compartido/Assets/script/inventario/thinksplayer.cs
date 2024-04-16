using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class thinksplayer : MonoBehaviour
{



    //NO ME SIRVIO
    // Referencia al �tem asociado al objeto del inventario
    public Item  item;
    public ItemType type;   

   

    // Componentes de texto para mostrar el nombre y la descripci�n del �tem
    public Text nombreText;
    public Text descripcionText;

    // Este m�todo se llama cuando el jugador selecciona el objeto en el inventario
    public void SeleccionarItem()
    {

        
        // Verifica si el �tem no es nulo
        if (item != null)
        {
            // Muestra el nombre y la descripci�n del �tem en los componentes de texto
            nombreText.text = "Nombre: " + item.name;
            descripcionText.text = "Descripci�n: " + item.description;
        }
    }
}

