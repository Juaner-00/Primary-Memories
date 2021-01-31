using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField] float time;

    [Header("Text")]
    [SerializeField] GameObject popUpTextBox;
    [SerializeField] GameObject popUpTextImage;
    [SerializeField] TMP_Text textText;
    [SerializeField] Animator animText;

    [Header("Thinking")]
    [SerializeField] GameObject popUpThinkingBox;
    [SerializeField] GameObject popUpThinkingImage;
    [SerializeField] TMP_Text thinkingText;
    [SerializeField] Animator animThinking;

    static PopUpSystem instance;
    public static PopUpSystem Instance => instance;

    Camera mainCamera;


    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    public void PopUpText(string text, Vector3 pos)
    {
        StartCoroutine(ShowText(text, pos));
    }

    public void PopUpThinking(string text, Vector3 pos)
    {
        StartCoroutine(ShowThinking(text, pos));
    }

    IEnumerator ShowText(string text, Vector3 pos)
    {
        popUpTextBox.SetActive(true);

        popUpTextImage.transform.position = mainCamera.WorldToScreenPoint(pos);

        textText.text = text;
        animText.SetTrigger("Pop");

        yield return new WaitForSeconds(time);

        animText.SetTrigger("Close");
    }

    IEnumerator ShowThinking(string text, Vector3 pos)
    {
        popUpThinkingBox.SetActive(true);

        popUpThinkingImage.transform.position = mainCamera.WorldToScreenPoint(pos);

        thinkingText.text = text;
        animThinking.SetTrigger("Pop");

        yield return new WaitForSeconds(time);

        animThinking.SetTrigger("Close");
    }
}
