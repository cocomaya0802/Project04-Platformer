using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        startPos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        float ydistance = cam.transform.position.y;
        float movement = cam.transform.position.x * (1 - parallaxEffect);

        transform.position = new Vector3(startPos + distance, startPos + ydistance, transform.position.z);
        if (movement > startPos + length)
        {
            startPos += length; 
        }
        else if (movement < startPos - length)
            {
            startPos -= length;
        }
    }
}
