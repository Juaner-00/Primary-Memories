using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpSystem : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] GameObject popUpTextBox;
    [SerializeField] TMP_Text textText;
    [SerializeField] Animator animText;

    [Header("Thinking")]
    [SerializeField] GameObject popUpThinkingBox;
    [SerializeField] TMP_Text thinkingText;
    [SerializeField] Animator animThinking;

    static PopUpSystem instance;
    public static PopUpSystem Instance => instance;


    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;
    }

    public void PopUpText(string text)
    {
        popUpTextBox.SetActive(true);
        textText.text = text;
        animText.SetTrigger("Pop");
    }

    public void PopUpThinking(string text)
    {
        popUpThinkingBox.SetActive(true);
        thinkingText.text = text;
        animThinking.SetTrigger("Pop");
    }
}
