using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponteiros : MonoBehaviour
{
   [SerializeField] GameObject caixinha;

    void OnColliderEnter(Collider hit)
    {
        if (hit.tag == "Ponteiro")
        {
            caixinha.SetActive(true);
        }

    }
     void OnColliderExit(Collider hit)
    {
         if (hit.tag == "Ponteiro")
        {
            caixinha.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
