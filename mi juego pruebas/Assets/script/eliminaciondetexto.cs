using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eliminaciondetexto : MonoBehaviour
{
    public Text textoUI;
    public float duracionActiva = 2.0f; // Duraci�n en segundos que el texto estar� activo

    private float tiempoInicio;

    void Start()
    {
        // Desactivamos el texto al inicio
        textoUI.enabled = false;
    }

    void Update()
    {
        // Verificamos si el texto est� activado y ha pasado la duraci�n activa
        if (textoUI.enabled && Time.time - tiempoInicio >= duracionActiva)
        {
            // Desactivamos el texto
            textoUI.enabled = false;
        }
    }

    // M�todo para activar el texto
    public void ActivarTexto(string texto)
    {
        // Mostramos el texto
        textoUI.text = texto;
        textoUI.enabled = true;

        // Actualizamos el tiempo de inicio
        tiempoInicio = Time.time;
    }
}
