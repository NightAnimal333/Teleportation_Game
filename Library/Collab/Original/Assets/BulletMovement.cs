using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public Vector3 direction;
    public CharacterController characterController;

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(direction * 1f * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer > 5){
            Destroy(gameObject);
        }
    }
}
