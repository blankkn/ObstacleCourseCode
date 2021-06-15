using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

  public Transform spawnPoint;
   int hits = 0;
  public int hitstoCount = 3;

 // ++ means add one more value, in this case, we are adding +1 to int hits.
  private void OnCollisionEnter(Collision collider) 
  {
    if(collider.gameObject.tag != "Hit")
    
    {
      hits++;
      if(hitstoCount <= hits)
      {
        transform.position = spawnPoint.transform.position;
        hits = 0;
      }

      Debug.Log("You Hit A Thing This Many Times: " + hits);
    }
    
       
  }
}