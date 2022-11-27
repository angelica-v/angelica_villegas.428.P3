using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceCreamGenerator : MonoBehaviour
{
    public GameObject CherryPiePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){

        Instantiate(CherryPiePrefab);
     }

}
