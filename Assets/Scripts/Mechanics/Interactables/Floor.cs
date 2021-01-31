using UnityEngine;

public class Floor : InteractableBase
{
    [SerializeField] float maxRange;
    [SerializeField] Texture2D cursorHover;


    public override void Start()
    {
        MaxRange = maxRange;
        CursorHover = cursorHover;
    }

    /* public override void OnStartHover()
    {
        Cursor.SetCursor(cursorImage, Vector2.zero, CursorMode.Auto);
    }

    public override void OnEndHover()
    {
        Cursor.SetCursor(Texture2D.whiteTexture, Vector2.zero, CursorMode.Auto);
    } */

    public override void OnInteract(Vector3 point)
    {
        PlayerMovement.Instance.Move(point);
    }
}
