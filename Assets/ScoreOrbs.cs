using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOrbs : MonoBehaviour
{

    public GameObject Pickup;

    void OnTriggerEnter() 
    {
        Destroy(Pickup);
        ScoreMenu.scoreValue += 1;
    }

}
