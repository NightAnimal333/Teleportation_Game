using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class teleportToNextLevel : MonoBehaviour
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

        if (collider.gameObject.tag == "Player"){
            SceneManager.LoadScene("Level0");
         
         
            print("PLAYER ENTERED");
        }


    }
}
