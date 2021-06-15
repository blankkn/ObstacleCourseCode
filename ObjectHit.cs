using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    // == means IS this thing, in this case, is the player.
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}