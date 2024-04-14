using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class informaciondeobjetos : MonoBehaviour
{
    public static bool invobj;
    public GameObject slotinf; //activa y desactiva
  
    void Start()
    {
        slotinf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void swishinformation()
    {
        if (invobj)
        {
            btnregresar();
        }
        else
        {
            btnslot();
        }
    }
    void btnregresar()
    {
        slotinf.SetActive(false);
        Time.timeScale = 1;
        invobj = false;

    }


    void btnslot()
    {
        slotinf.SetActive(true);
        Time.timeScale = 0;
        invobj = true;
    }
}
