using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente : MonoBehaviour
{

    [SerializeField]
    GameObject puente, cuerda1, cuerda2, cuerda3, cuerda4;
    

    public void Update()
    {
        if (cuerda1.GetComponent<Rigidbody>().useGravity == true && cuerda3.GetComponent<Rigidbody>().useGravity == true)
        {
            puente.GetComponent<Rigidbody>().useGravity = true;
            puente.GetComponent<Rigidbody>().isKinematic = false;
        }
    }








}
