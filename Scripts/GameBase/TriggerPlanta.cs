using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlanta : MonoBehaviour
{
    [SerializeField]
    public Animator jump;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlantaForm")
        {
           jump.GetComponent<Animator>().enabled = false;
           
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlantaForm")
        {
            jump.GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("jump");
            
        }
    }
}

