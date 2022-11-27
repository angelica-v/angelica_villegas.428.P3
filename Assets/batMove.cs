using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batMove : MonoBehaviour
{
    private Vector3 batLocation;
    int randomValue;
    private Vector3 startLocation;


    
    // Start is called before the first frame update
    void Start()
    {
        batLocation = transform.position;
        startLocation = batLocation + new Vector3(-10.0f * Mathf.Sin(0), 0.0f, 2.81f * Mathf.Cos(0)); 
    }
    

    // Update is called once per frame
    void Update()
    {
        if( transform.position == startLocation || transform.position == batLocation) {
           randomValue =  Random.Range(2, 10);
        }

        // 0.22 works
        transform.position = batLocation + new Vector3(-10.0f * Mathf.Sin(Time.time / randomValue), 0.0f, 2.81f * Mathf.Cos(Time.time / randomValue)); 
    }
}
