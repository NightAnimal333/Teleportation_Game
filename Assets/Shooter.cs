using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public CharacterController characterController;
    public GameObject bullet;

    public float shootingIntervals = 2f;

    private float timer = 0f;

    public Transform playerCharacter;

        // Start is called before the first frame update
    void Start()
    {
        //bullet.direction = new Vector3(playerCharacter.position.x, playerCharacter.position.y, playerCharacter.position.z);


    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > shootingIntervals){
            Shoot();
            timer = 0f;
        }

        //print(playerCharacter.position);


        // Vector3 direction = new Vector3(playerCharacter.position.x, playerCharacter.position.y, playerCharacter.position.z);

        //  characterController.Move(direction * 1f * Time.deltaTime);

    }

    void Shoot(){

        GameObject bulletObject = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Vector3 newDirection = playerCharacter.position - transform.position;
        
        newDirection.Normalize();
        bulletObject.GetComponent<BulletMovement>().direction = newDirection;

    }

    void OnTriggerEnter(Collider collider){

        print("I COLLIDED");
        print(collider.gameObject.tag);

        if (collider.gameObject.tag == "weapon"){

            Destroy(gameObject);

        }

    }
}
