using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicaguardado : MonoBehaviour
{
    public static musicaguardado instance;
    //sonidooooo 7W7
    private AudioSource audioS;
    public Slider VSlider;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();

        VSlider.value = PlayerPrefs.GetFloat("sonidoValumen", 0.5F); //guardado
    }

  
    // Update is called once per frame
    void Update()
    {
        audioS.volume = VSlider.value;
    }

}
