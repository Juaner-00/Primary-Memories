using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuerdas2 : InteractableBase
{

    [SerializeField] float maxRange;
    [SerializeField] Texture2D cursorHover;
    [SerializeField]
    GameObject Puente, cuerda1, cuerda2, cuerda3, cuerda4;

    [SerializeField] string textPopUp;



    public override void Start()
    {
        MaxRange = maxRange;
        CursorHover = cursorHover;
    }

    public override void OnInteract(Vector3 point)
    {
        if (Vector3.Distance(transform.position, GameManager.Player.transform.position) <= maxRange)
        {

            PopUpSystem.Instance.PopUpText(textPopUp, transform.position + Vector3.up * 0.8f);
            cuerda3.GetComponent<Rigidbody>().useGravity = true;
            cuerda3.GetComponent<Rigidbody>().isKinematic = false;
            cuerda4.GetComponent<Rigidbody>().useGravity = true;
            cuerda4.GetComponent<Rigidbody>().isKinematic = false;

        }
        else
        {
            PopUpSystem.Instance.PopUpThinking("Can't reach that", GameManager.Player.transform.position + Vector3.up * 3);
        }
    }



}