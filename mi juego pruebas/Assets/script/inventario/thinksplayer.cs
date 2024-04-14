using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thinksplayer : MonoBehaviour
{
    public string TextoAmostrar = " Las recuerdo, son mis medicamentos. Me había enfermado, aunque no recuerdo de que, y me recetaron estas pastillas, y… creo que se me habían… terminado.";
    public Text textoUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Colisión detectada con el jugador");
            textoUI.text = TextoAmostrar;
            Debug.Log("Texto mostrado: " + TextoAmostrar);
        }

        if (other.CompareTag("Player"))
        {
            textoUI.text = TextoAmostrar;
            Debug.Log("Texto mostrado" + TextoAmostrar);
        }
    }


}
