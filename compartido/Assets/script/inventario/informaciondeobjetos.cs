using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class informaciondeobjetos : MonoBehaviour
{
    public static bool invobj;
    public GameObject panelinf; // Panel que contiene la informaci�n del objeto
    public UnityEngine.UI.Text textoInfo; // Referencia al objeto de texto que mostrar� la informaci�n

    void Start()
    {
       panelinf.SetActive(false); // Desactiva el panel al iniciar
    }

    // M�todo para mostrar la informaci�n del objeto
    public void MostrarInformacion(PlantillaOBjescriptable objeto)
    {
        if (objeto != null)
        {
            // Muestra la informaci�n del objeto en el panel
            textoInfo.text = "" + objeto.textoName + "\n" + "" + objeto.textoDesc;
            // Activa el panel
            panelinf.SetActive(true);
            // Pausa el tiempo del juego
            Time.timeScale = 0;
            // Cambia el estado de invobj
            invobj = true;
        }
    }

    // M�todo para ocultar el panel de informaci�n
    public void OcultarInformacion()
    {
        // Oculta el panel
        panelinf.SetActive(false);
        // Reanuda el tiempo del juego
        Time.timeScale = 1;
        // Cambia el estado de invobj
        invobj = false;
    }

    // M�todo para cambiar entre mostrar u ocultar la informaci�n
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
