using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class informaciondeobjetos : MonoBehaviour
{
    public static bool invobj;
    public GameObject panelinf; // Panel que contiene la información del objeto
    public UnityEngine.UI.Text textoInfo; // Referencia al objeto de texto que mostrará la información

    void Start()
    {
       panelinf.SetActive(false); // Desactiva el panel al iniciar
    }

    // Método para mostrar la información del objeto
    public void MostrarInformacion(PlantillaOBjescriptable objeto)
    {
        if (objeto != null)
        {
            // Muestra la información del objeto en el panel
            textoInfo.text = "" + objeto.textoName + "\n" + "" + objeto.textoDesc;
            // Activa el panel
            panelinf.SetActive(true);
            // Pausa el tiempo del juego
            Time.timeScale = 0;
            // Cambia el estado de invobj
            invobj = true;
        }
    }

    // Método para ocultar el panel de información
    public void OcultarInformacion()
    {
        // Oculta el panel
        panelinf.SetActive(false);
        // Reanuda el tiempo del juego
        Time.timeScale = 1;
        // Cambia el estado de invobj
        invobj = false;
    }

    // Método para cambiar entre mostrar u ocultar la información
    public void swishinformation(PlantillaOBjescriptable objeto)
    {
        if (invobj)
        {
            OcultarInformacion();
        }
        else
        {
            MostrarInformacion(objeto);
        }
    }
}
