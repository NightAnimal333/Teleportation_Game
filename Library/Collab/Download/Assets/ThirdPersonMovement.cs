using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public GameObject teleportSphere;
    public Transform cam;


    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    public float gravity = 14f;
    public float jumpForce = 10f;
    float verticalVelocity;
    int canJump = 1;



    // Update is called once per frame
    void Update()
    {
     
        // Movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed *  Time.deltaTime);

        // Jumping
        if (controller.isGrounded)
        {
            canJump = 1;    
            verticalVelocity = -gravity * Time.deltaTime;
        }
        else 
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // When you press spacebar, jump
        if (Input.GetKeyDown(KeyCode.Space) && canJump >= 1)
        {
            verticalVelocity = jumpForce;
            canJump = 0;
        }
        Vector3 jumpVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(jumpVector * Time.deltaTime);

        if (Input.GetMouseButtonDown(0)){

            GameObject teleportSphereObject = Instantiate(teleportSphere, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.identity);
            Vector3 newDirection = cam.transform.forward;//playerCharacter.position - transform.position;
            
            newDirection.Normalize();
            teleportSphereObject.GetComponent<TeleportSphere>().direction = newDirection;
            teleportSphereObject.GetComponent<TeleportSphere>().daddyPlayer = gameObject;


        }

    }

}
