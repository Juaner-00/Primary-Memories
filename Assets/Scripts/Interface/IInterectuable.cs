using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInterectuable
{
    bool IsInteractuable { get; }

    void OnInteract();
}
