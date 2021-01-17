using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){

        print("wall collishun");

        if (collision.gameObject.tag == "playerPart"){

        //collision.gameObject.GetComponent<CharacterController>().setIsGrounded(true);

        print("wall collishun playerPart");

          GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        }

    }

}
