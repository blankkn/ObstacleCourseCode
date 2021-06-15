using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    Renderer rendererr; 
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rendererr = GetComponent<Renderer>();

        rigidBody = GetComponent<Rigidbody>();
        
        rigidBody.useGravity = false;

        rendererr.enabled = false;
    }
    // Time.time is equivelant to a stopwatch.
    void Update()
    {
        if(Time.time > timeToWait)
        {
         rigidBody.useGravity = true;
         rendererr.enabled = true;
        }
    }
}
