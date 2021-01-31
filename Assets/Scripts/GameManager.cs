using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Texture2D cursorNormal;

    public Texture2D CursorNormal => cursorNormal;

    static GameObject player;
    public static GameObject Player => player;

    static GameManager instance;
    public static GameManager Instance => instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        Cursor.SetCursor(cursorNormal, Vector2.zero, CursorMode.Auto);
    }

}
