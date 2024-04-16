using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIccionario : MonoBehaviour
{
    public Sprite imagen1;
    public Sprite imagen2;
    public Sprite imagen;
    // Declara un diccionario que mapea Sprites a strings
    Dictionary<Sprite, string> diccionarioImagenes = new Dictionary<Sprite, string>();

    void Start()
    {
        // Agrega elementos al diccionario
        diccionarioImagenes[imagen1] = "Descripci�n de la imagen 1";
        diccionarioImagenes[imagen2] = "Descripci�n de la imagen 2";
        // Contin�a agregando m�s elementos seg�n necesites

        // Accede y muestra elementos del diccionario
        string descripcion = diccionarioImagenes[imagen1];
        Debug.Log("La descripci�n de la imagen 1 es: " + descripcion);

        // Verifica si una imagen existe en el diccionario
        if (diccionarioImagenes.ContainsKey(imagen))
        {
            string descripcionImagen3 = diccionarioImagenes[imagen];
            Debug.Log("La descripci�n de la imagen 3 es: " + descripcionImagen3);
        }
        else
        {
            Debug.Log("La imagen 3 no est� en el diccionario.");
        }

        // Itera sobre todos los elementos del diccionario
        foreach (KeyValuePair<Sprite, string> kvp in diccionarioImagenes)
        {
            Sprite imagen = kvp.Key;
            string descripcionImagen = kvp.Value;
            Debug.Log("Descripci�n de la imagen " + imagen.name + ": " + descripcionImagen);
        }
    }
}
