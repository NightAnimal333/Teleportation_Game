using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSphere : MonoBehaviour
{

    public Vector3 direction;
    public CharacterController characterController;
    public GameObject daddyPlayer;

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

            daddyPlayer.GetComponent<CharacterController>().enabled = false;
            daddyPlayer.transform.position = transform.position;
            daddyPlayer.GetComponent<CharacterController>().enabled = true;

            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "platform"){
           // print("Henlo123 platform");


            daddyPlayer.GetComponent<CharacterController>().enabled = false;
            daddyPlayer.transform.position = transform.position;
            daddyPlayer.GetComponent<CharacterController>().enabled = true;

            Destroy(gameObject);


        }

    }
}
