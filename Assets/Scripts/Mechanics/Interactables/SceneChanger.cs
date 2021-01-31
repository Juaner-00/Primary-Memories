using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : InteractableBase
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
            StartCoroutine(Change());
        }
        else
        {
            PopUpSystem.Instance.PopUpThinking("Can't reach that", GameManager.Player.transform.position + Vector3.up * 3);
        }
    }

    IEnumerator Change()
    {
        PopUpSystem.Instance.PopUpThinking(textPopUp, GameManager.Player.transform.position + Vector3.up * 2);

        yield return new WaitForSeconds(3);

        _SceneManager.Instance.LoadNextLevel();
    }
}
