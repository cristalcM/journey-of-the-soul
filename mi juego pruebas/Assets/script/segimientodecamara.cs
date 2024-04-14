using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segimientodecamara : MonoBehaviour
{
    public Transform targer;
    public float speed;
    public Vector3 positioncamera;


    private void FixedUpdate()
    {
       Vector3 Oposition = targer.position + positioncamera;
       Vector3 Sposition = Vector3.Lerp(transform.position, Oposition, speed * Time.deltaTime);

        transform.position = Sposition;
    }
}
