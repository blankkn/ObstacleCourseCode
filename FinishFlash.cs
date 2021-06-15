using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFlash : MonoBehaviour
{
    public float speed;
    Renderer renderrrrrr; 
    // Start is called before the first frame update
    void Start()
    {
        renderrrrrr = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float hue = Mathf.Sin(Time.time * speed)/2.0f + 1.0f;
        renderrrrrr.material.color = Color.HSVToRGB(hue,1.0f,1.0f); // * Mathf.Sin(Time.time * speed);
    }
}
 