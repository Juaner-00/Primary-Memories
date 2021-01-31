using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.LSS;


public class _SceneManager : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    [SerializeField] float time;
    [SerializeField] bool loadWithTime;

    public static _SceneManager Instance { get; private set; }

    public LoadingScreenManager lsm; // Your LSM variable


    private void Awake()
    {
        if (Instance != null)
            Destroy(this);
        Instance = this;
    }

    private void Start()
    {
        if (loadWithTime)
        {
            Invoke("LoadNextLevel", time);
        }
    }

    public void LoadNextLevel()
    {
        lsm.LoadScene(nextLevelName);
    }

}