using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneManager : MonoBehaviour
{
    [SerializeField]
    string nextLevelName;

    public static _SceneManager Instance { get; private set; }

    private List<AsyncOperation> levelsLoading = new List<AsyncOperation>();

    private void Awake()
    {
        if (Instance != null)
            Destroy(this);
        Instance = this;
    }

    public void LoadNextLevel()
    {
        
        levelsLoading.Add(SceneManager.LoadSceneAsync(nextLevelName/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void Reset()
    {
     
        levelsLoading.Add(SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadMainMenu()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Islands"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private IEnumerator GetSceneLoadProgress()
    {
        foreach (var scene in levelsLoading)
            while (!scene.isDone)
                yield return null;

    
        levelsLoading.Clear();
    }

    public void LoadLvl1()
    {

      
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_01"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl2()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_02"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl3()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_03"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl4()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_04"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());

    }
    public void LoadLvl5()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_05"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());

    }
    public void LoadLvl6()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_06"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl7()
    {
     
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_07"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl8()
    {
     
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_08"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl9()
    {
        
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_09"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl10()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_10"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }

    public void LoadLvl11()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_11"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }
    public void LoadLvl12()
    {
       
        levelsLoading.Add(SceneManager.LoadSceneAsync("Tutorial Level_12"/* , LoadSceneMode.Additive */));
        levelsLoading.Add(SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex));

        StartCoroutine(GetSceneLoadProgress());
    }


}