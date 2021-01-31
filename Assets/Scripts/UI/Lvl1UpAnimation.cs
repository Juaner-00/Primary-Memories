using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1UpAnimation : MonoBehaviour
{
    public Transform position1, position2;
    [SerializeField]
    GameObject cam1, cam2, controlerUI;
    [SerializeField]
    float speed;
    [SerializeField]
    Animator wakeupAnimation;
   
    

    bool activador = false;

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
                wakeupAnimation.SetBool("presionoBotonplay", true);
            }
        }
    }

    public void clickPlay()
    {
        activador = true;
        

        
        
        controlerUI.SetActive(false);
    }
}
