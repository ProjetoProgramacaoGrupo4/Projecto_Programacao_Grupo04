using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionegg1 : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

        Destroy(gameObject);
    }
}





