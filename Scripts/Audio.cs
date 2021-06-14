using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SoundTrigger"))
        {
            other.GetComponent<AudioSource>().Play();
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("SoundTrigger"))
        {
            other.GetComponent<AudioSource>().Stop();
        }
    }
}

