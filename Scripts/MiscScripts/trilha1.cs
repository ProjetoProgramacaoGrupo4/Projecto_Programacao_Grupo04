using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trilha1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject sound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sound.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound.SetActive(false);
        }
    }


}
