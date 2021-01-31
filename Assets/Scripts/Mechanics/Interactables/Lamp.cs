using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : InteractableBase
{
    [SerializeField] float maxRange;
    [SerializeField] Texture2D cursorHover;

    [SerializeField] string textPopUp;

    [SerializeField] Light luz;


    int interacted;


    public override void Start()
    {
        MaxRange = maxRange;
        CursorHover = cursorHover;

        interacted = 0;
    }

    public override bool CanInteract()
    {
        return interacted < 1;
    }

    public override void OnInteract(Vector3 point)
    {
        if (interacted < 1)
        {
            if (Vector3.Distance(transform.position, GameManager.Player.transform.position) <= maxRange)
            {
                interacted++;
                // PopUpSystem.Instance.PopUpText(textPopUp, transform.position + Vector3.up * 2);
                luz.enabled = false;

                OnEndHover();
            }
            else
            {
                PopUpSystem.Instance.PopUpThinking("Can't reach that", GameManager.Player.transform.position + Vector3.up * 3);
            }
        }
    }
}
