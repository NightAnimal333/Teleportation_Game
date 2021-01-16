using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform destination;
    int canTeleport = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){

        print("TeleportHenlo");
        print(collider.transform.position);
        print(destination.position);

        if (canTeleport >= 1)
        {
            collider.GetComponent<CharacterController>().enabled = false;
            collider.transform.position = destination.position;
            collider.GetComponent<CharacterController>().enabled = true;
            canTeleport -= 2;
        }


    }

    void OnTriggerExit(Collider other) {
        canTeleport += 1;
    }

}
