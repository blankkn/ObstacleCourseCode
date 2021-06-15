using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{ 
    public float moveSpeed = 10f;

    // Start is called immediately, will not loop. 
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void MovePlayer()
    {
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    
    transform.Translate(xValue,0,zValue);

    }
}
