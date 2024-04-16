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
        diccionarioImagenes[imagen1] = "Descripción de la imagen 1";
        diccionarioImagenes[imagen2] = "Descripción de la imagen 2";
        // Continúa agregando más elementos según necesites

        // Accede y muestra elementos del diccionario
        string descripcion = diccionarioImagenes[imagen1];
        Debug.Log("La descripción de la imagen 1 es: " + descripcion);

        // Verifica si una imagen existe en el diccionario
        if (diccionarioImagenes.ContainsKey(imagen))
        {
            string descripcionImagen3 = diccionarioImagenes[imagen];
            Debug.Log("La descripción de la imagen 3 es: " + descripcionImagen3);
        }
        else
        {
            Debug.Log("La imagen 3 no está en el diccionario.");
        }

        // Itera sobre todos los elementos del diccionario
        foreach (KeyValuePair<Sprite, string> kvp in diccionarioImagenes)
        {
            Sprite imagen = kvp.Key;
            string descripcionImagen = kvp.Value;
            Debug.Log("Descripción de la imagen " + imagen.name + ": " + descripcionImagen);
        }
    }
}
