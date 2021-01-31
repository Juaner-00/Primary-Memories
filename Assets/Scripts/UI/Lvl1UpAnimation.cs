using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1UpAnimation : MonoBehaviour
{
    public Transform position1, position2,position3;
    [SerializeField]
    GameObject cam1, cam2, botonPlay, botonExit;
    [SerializeField]
    float speed;
    [SerializeField]
    Animator wakeupAnimation;



    bool activador = false, activadorExit = false;

    float t;
    // Start is called before the first frame update
    void Start()
    {
        cam1.transform.position = position1.position;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(activador == true)
        {
            cam1.transform.position = Vector3.MoveTowards(cam1.transform.position, position2.position, speed);
            if(cam1.transform.position == position2.position)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                
            }
        }
        if (activadorExit == true)
        {
            cam1.transform.position = Vector3.MoveTowards(cam1.transform.position, position3.position,10* speed);
            if(cam1.transform.position == position3.position)
            {
                Application.Quit();
            }
        }
    }

    public void clickPlay()
    {
        activador = true;

        wakeupAnimation.SetBool("presionoBotonplay", true); 


        botonExit.SetActive(false);
        botonPlay.SetActive(false);
    }
    public void clickExit()
    {
        activadorExit = true;
        botonExit.SetActive(false);
        botonPlay.SetActive(false);
    }
}
