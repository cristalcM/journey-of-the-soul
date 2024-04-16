using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Teletransporte : MonoBehaviour
{

    new public Collider2D collider;
    public LayerMask layer;
    public Transform destinationtransform;
    public float delaytime = 0.3f;
    public AudioSource audiosource;
    public AudioClip teleportSound;
    WaitForSeconds delay;

    IEnumerator Active(GameObject teletransporte)
    {
        if (destinationtransform)
        {
            yield return delay;
            teletransporte.transform.position =destinationtransform.position;
            teletransporte.transform.rotation = destinationtransform.rotation;
            audiosource.PlayOneShot(teleportSound);
        }
    }
    
    void Start()
    {
        collider = GetComponent<Collider2D>();
        collider.isTrigger = true;  
    }

    // Update is called once per frame
    void Update()
    {
        delay = new WaitForSeconds(delaytime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Istelepottable(other)) StartCoroutine(Active(other.gameObject));
       
    }

    private bool Istelepottable(Collider2D other)
    {
      return 0 != (layer.value & 1 << other.gameObject.layer);
        
    }
}
