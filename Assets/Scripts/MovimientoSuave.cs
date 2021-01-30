using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSuave : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    float speed;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, t * speed);
    }
}
