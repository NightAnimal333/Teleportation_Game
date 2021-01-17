using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform destination;
  //  int canTeleport = 1;

    bool canTeleport = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){


        if (collider.gameObject.tag == "Player"){
        }

        if (canTeleport && collider.gameObject.tag == "Player")
        {
            collider.GetComponent<CharacterController>().enabled = false;
            collider.transform.position = destination.position;
            collider.GetComponent<CharacterController>().enabled = true;
            destination.GetComponent<Teleport>().canTeleport = false;
        }


    }

    void OnTriggerExit(Collider collider) {
        if (collider.gameObject.tag == "Player"){
            canTeleport = true;
        }
    }

}
