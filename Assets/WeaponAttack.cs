using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    public GameObject daddyPlayer;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(daddyPlayer.transform.forward);

        transform.position = daddyPlayer.transform.position + (daddyPlayer.transform.forward * 1.75f);

        timer += Time.deltaTime;

        if(timer > 1){

            Destroy(gameObject);

        }
        
    }
}
