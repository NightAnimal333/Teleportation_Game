using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFormation : MonoBehaviour
{

    public GameObject prefab;
    public int numberOfObject = 100;
    public float radius = 15;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfObject; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObject;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
