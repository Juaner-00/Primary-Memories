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

    public virtual void OnEndHover()
    {
        Cursor.SetCursor(GameManager.Instance.CursorNormal, Vector2.zero, CursorMode.Auto);
    }

    public virtual void OnStartHover()
    {
        Cursor.SetCursor(CursorHover, Vector2.zero, CursorMode.Auto);
    }
}
