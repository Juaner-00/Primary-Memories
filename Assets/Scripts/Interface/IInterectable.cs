using UnityEngine;

public interface IInterectable
{
    float MaxRange { get; }
    Texture2D CursorHover { get; }


    void OnStartHover();
    void OnEndHover();
    void OnInteract(Vector3 point);
    bool CanInteract();
}
