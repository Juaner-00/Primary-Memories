using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;

    // bool isWalking

    private void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                agent.destination = hit.point;
            }
        }

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            // isWalking = true;
        }
        else
        {
            // isWalking = false
        }


        // anim.SetBool("walking", isWalking);
    }
}
