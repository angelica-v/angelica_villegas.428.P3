using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainMove : MonoBehaviour
{
    private Vector3 trainLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        trainLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = trainLocation + new Vector3(-5.15f * Mathf.Sin(Time.time / 8), 0.0f, 0.0f); 
    }
}
