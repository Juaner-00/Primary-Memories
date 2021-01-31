using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;

    static PlayerMovement instance;
    public static PlayerMovement Instance { get => instance; }


    bool isWalking;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        isWalking = (agent.remainingDistance <= agent.stoppingDistance);
        
        
        anim.SetBool("walking", isWalking);
    }

    public void Move(Vector3 pos)
    {
        agent.destination = pos;
    }
}
