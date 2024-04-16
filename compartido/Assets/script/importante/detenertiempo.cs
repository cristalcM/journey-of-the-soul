using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detenertiempo : MonoBehaviour
{
   

    private void OnEnable()
    {
        DetenerTiempo();
    }

    private void OnDisable()
    {
        ReanudarTiempo();
    }

    private void DetenerTiempo()
    {
       
        Time.timeScale = 0; // Detener el tiempo
    }

    private void ReanudarTiempo()
    {
        Time.timeScale = 1; // Reanudar el tiempo al valor original
    }
}
