using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorySceneManager : MonoBehaviour
{

    public float t=0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneChange", t);
    }

    // Update is called once per frame
    void SceneChange()
    {
        _SceneManager.Instance.LoadNextLevel();
    }
}
