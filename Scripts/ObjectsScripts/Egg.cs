using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject eggPrefab;   
    float dropDelay = 0;

    void Update()
    {
        if (dropDelay > 0)
        {
            dropDelay -= Time.deltaTime;
        }
        else
        {
            Instantiate(eggPrefab, transform.position, transform.rotation);
            dropDelay = Random.Range(1.0f, 2.0f);    
        }
    }
}


