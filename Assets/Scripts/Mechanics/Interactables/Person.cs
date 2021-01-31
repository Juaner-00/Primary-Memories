using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : InteractableBase
{
    [SerializeField] float maxRange;
    [SerializeField] Texture2D cursorHover;

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
        }
        else
        {
            PopUpSystem.Instance.PopUpThinking("Can't reach that", GameManager.Player.transform.position + Vector3.up * 3);
        }
    }
}
