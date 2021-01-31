using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaInteract : InteractableBase
{
    [SerializeField] float maxRange;
    [SerializeField] Texture2D cursorHover;
    [SerializeField]
    GameObject espadaFunda, espadaMano, espadaSuelo;

    [SerializeField] string textPopUp;
    [SerializeField] float tiempo;


    public override void Start()
    {
        MaxRange = maxRange;
        CursorHover = cursorHover;
    }

    public override void OnInteract(Vector3 point)
    {
        if (Vector3.Distance(transform.position, GameManager.Player.transform.position) <= maxRange)
        {
            GameManager.Player.GetComponent<Animator>().SetTrigger("espada");
            PopUpSystem.Instance.PopUpText(textPopUp, transform.position + Vector3.up * 0.8f);
            Invoke("Recoger",tiempo);
            
        }
        else
        {
            PopUpSystem.Instance.PopUpThinking("Can't reach that", GameManager.Player.transform.position + Vector3.up * 3);
        }
    }
    public void Recoger()
    {
        espadaSuelo.GetComponent<MeshRenderer>().enabled = false;
        espadaSuelo.GetComponent<BoxCollider>().enabled = false;
        espadaMano.GetComponent<MeshRenderer>().enabled = true;
    }
    


}
