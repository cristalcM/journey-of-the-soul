using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eliminaciondetexto : MonoBehaviour
{
    public Text textoUI;
    public float duracionActiva = 2.0f; // Duración en segundos que el texto estará activo

    private float tiempoInicio;

    void Start()
    {
        // Desactivamos el texto al inicio
        textoUI.enabled = false;
    }

    void Update()
    {
        // Verificamos si el texto está activado y ha pasado la duración activa
        if (textoUI.enabled && Time.time - tiempoInicio >= duracionActiva)
        {
            // Desactivamos el texto
            textoUI.enabled = false;
        }
    }

    // Método para activar el texto
    public void ActivarTexto(string texto)
    {
        // Mostramos el texto
        textoUI.text = texto;
        textoUI.enabled = true;

        // Actualizamos el tiempo de inicio
        tiempoInicio = Time.time;
    }
}
