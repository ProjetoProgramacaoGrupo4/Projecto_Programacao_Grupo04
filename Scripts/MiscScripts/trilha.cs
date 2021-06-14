using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trilha : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject trilha1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            trilha1.SetActive(true);
        }
    }

    
}
