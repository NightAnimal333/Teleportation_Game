using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public Vector3 direction;
    public CharacterController characterController;

    public float speed = 10f;
    public float lifeTime = 5f; 

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(direction * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer > lifeTime){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision){


        if (collision.gameObject.tag == "wall"){
           // print("Henlo123 wall");

            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "platform"){
           // print("Henlo123 platform");


            Destroy(gameObject);

        }

    }

    void OnTriggerEnter(Collider collider){

        if (collider.gameObject.tag == "weapon"){
            direction *= -1;
        }

    }
}
