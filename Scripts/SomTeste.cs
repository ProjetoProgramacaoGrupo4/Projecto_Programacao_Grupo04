using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomTeste : MonoBehaviour
{

    public AudioSource playSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }
}
