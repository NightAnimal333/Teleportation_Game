using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){

         if (collider.gameObject.tag == "killer"){

            Destroy(gameObject);


         }


    }

    void OnCollisionEnter(Collision collision){

         if (collision.gameObject.tag == "killer"){

            Destroy(gameObject);


         }


    }
}
