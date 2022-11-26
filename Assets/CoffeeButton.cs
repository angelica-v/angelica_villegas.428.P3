using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeButton : MonoBehaviour
{
    public GameObject Teleport1;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
       //Teleport1.SetActualTeleportDestination(new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f));
       // Vector3 actualPosition = new Vector3(0.0f, 0.0f, 0.0f);
        // teleporter.SetActualTeleportDestination(actualPosition,  new Vector3(0.0f, 0.0f, 0.0f));
     }
}
