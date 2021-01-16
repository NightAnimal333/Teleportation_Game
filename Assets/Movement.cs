using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public Transform cameraHolder; 


    public float speed = 6f;
    public float lookSpeed = 6f;

    public float mouseSensitivity = 2f;
    public float upLimit = -50;
    public float downLimit = 50;

    Vector2 rotation = new Vector2 (0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    private void Move(){

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0, verticalMove);
        characterController.Move(speed * Time.deltaTime * move);


    }

    public void Rotate(){
		rotation.y += Input.GetAxis ("Mouse X");
		rotation.x += -Input.GetAxis ("Mouse Y");
		transform.eulerAngles = (Vector2)rotation * lookSpeed;
    }
    

    public void RotateFPS()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
        transform.eulerAngles = new Vector2(0,rotation.y) * lookSpeed;
        cameraHolder.localRotation = Quaternion.Euler(rotation.x * lookSpeed, 0, 0);
    }

    public void RotateCustom()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
        transform.eulerAngles = new Vector2(0,rotation.y) * lookSpeed;
        cameraHolder.localRotation = Quaternion.Euler(rotation.x * lookSpeed, 0, 0);
    }
}
