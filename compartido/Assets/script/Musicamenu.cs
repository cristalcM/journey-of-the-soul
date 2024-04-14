using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicamenu : MonoBehaviour
{
    public static bool gamep;
    public GameObject configp; //activa y desactiva

    //sonidooooo 7W7
    private AudioSource audioS;
    public Slider VSlider;

    void Start()
    {
        configp.SetActive(false);
        audioS = GetComponent<AudioSource>();
        
        VSlider.value = PlayerPrefs.GetFloat("sonidoValumen", 0.5F); //guardado
    }
     void Update()
    {
        audioS.volume = VSlider.value;
    }


    public void SwitchSonido()
    {
        if (gamep)
        {
            btnsalir();
        }
        else
        {
            btnconfig();
        }
    }
    void btnsalir()
    {
        configp.SetActive(false);
        Time.timeScale = 1;
        gamep = false;

        //sonido guardado 
        PlayerPrefs.SetFloat("sonidoValumen", audioS.volume);

    }

  
    void btnconfig()
    {
        configp.SetActive(true);
        Time.timeScale = 0;
        gamep = true;
    }


}
