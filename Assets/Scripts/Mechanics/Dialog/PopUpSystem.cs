using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField] float time;

    GameObject popUpTextBox;
    GameObject popUpTextImage;
    TMP_Text textText;
    Animator animText;

    GameObject popUpThinkingBox;
    GameObject popUpThinkingImage;
    TMP_Text thinkingText;
    Animator animThinking;

    static PopUpSystem instance;
    public static PopUpSystem Instance => instance;

    Camera mainCamera;


    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;

        popUpTextBox = GameObject.FindGameObjectWithTag("Text");
        popUpTextImage = popUpTextBox.transform.GetChild(0).gameObject;
        textText = popUpTextImage.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        animText = popUpTextImage.GetComponent<Animator>();

        popUpThinkingBox = GameObject.FindGameObjectWithTag("Think");
        popUpThinkingImage = popUpThinkingBox.transform.GetChild(0).gameObject;
        thinkingText = popUpThinkingImage.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        animThinking = popUpThinkingImage.GetComponent<Animator>();
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
        popUpTextImage.transform.position = mainCamera.WorldToScreenPoint(pos);

        textText.text = text;
        animText.SetTrigger("Pop");

        yield return new WaitForSeconds(time);

        animText.SetTrigger("Close");
    }

    IEnumerator ShowThinking(string text, Vector3 pos)
    {
        popUpThinkingImage.transform.position = mainCamera.WorldToScreenPoint(pos);

        thinkingText.text = text;
        animThinking.SetTrigger("Pop");

        yield return new WaitForSeconds(time);

        animThinking.SetTrigger("Close");
    }
}
