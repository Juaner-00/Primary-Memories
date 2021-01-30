using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogPopUp : MonoBehaviour
{
    [SerializeField] GameObject popUpBox;
    [SerializeField] TMP_Text popUpText;
    [SerializeField] Animator anim;


    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        anim.SetTrigger("Pop");
    }
}
