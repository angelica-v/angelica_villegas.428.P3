using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horsecarousel : MonoBehaviour
{
    private Vector3 horseLocation;

    // Start is called before the first frame update
    void Start()
    {
        horseLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = horseLocation + new Vector3(0.0f, 0.0f, -11.0f * Mathf.Sin(Time.time / 8)); 

    }
}
