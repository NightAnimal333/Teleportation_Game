using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Renderer>().material.color = Color.white;

        
    }

    void OnMouseEnter(){
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
