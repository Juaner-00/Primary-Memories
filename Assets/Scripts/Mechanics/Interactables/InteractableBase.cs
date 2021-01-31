using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableBase : MonoBehaviour, IInterectable
{
    public float MaxRange { get; set; }
    public Texture2D CursorHover { get; set; }


    public static event InteractableEvent CantReach;
    public delegate void InteractableEvent();


    public abstract void Start();

    public abstract void OnInteract(Vector3 point);

    public virtual bool CanInteract()
    {
        return true;
    }

    public virtual void OnStartHover()
    {
        Cursor.SetCursor(CursorHover, new Vector2(16, 16), CursorMode.Auto);
    }

    public virtual void OnEndHover()
    {
        Cursor.SetCursor(GameManager.Instance.CursorNormal, new Vector2(16, 16), CursorMode.Auto);
    }

}
