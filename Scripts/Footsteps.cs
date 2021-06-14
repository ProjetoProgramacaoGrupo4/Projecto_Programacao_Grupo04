using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField] GameObject passos;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            
            passos.SetActive(true);
        } else if(Input.GetKeyUp(KeyCode.W))
        {
            passos.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            
            passos.SetActive(true);
        }else if(Input.GetKeyUp(KeyCode.A))
        {
            passos.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            
            passos.SetActive(true);
        }else if(Input.GetKeyUp(KeyCode.S))
        {
            passos.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            
            passos.SetActive(true);
        }else if(Input.GetKeyUp(KeyCode.D))
        {
            passos.SetActive(false);
        }
    }
}
