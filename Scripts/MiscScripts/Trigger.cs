using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Door;
    public GameObject Luz;
    public bool LuzPorta = false;
    
    
    // Start is called before the first frame update

    void Start()
    {
        Luz.SetActive(false);
        LuzPorta = false;
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Ponteiro")
        {
            LuzPorta = true;
            Luz.SetActive(true);
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Ponteiro")
        {
            LuzPorta = false;
            Luz.SetActive(false);
        }
    }
        void Update()
        {
        if (LuzPorta == true)
        {
            Door.transform.position = new Vector3(555, 7 - 12f, -266);
        }
        else {
            Door.transform.position = new Vector3(555, 7, -266);
        }
        }
    
}
