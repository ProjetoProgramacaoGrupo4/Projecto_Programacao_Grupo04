using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject Door2;
    public GameObject Luz2;
    public bool LuzPorta = false;
    [SerializeField] GameObject oaawnoaawn;
    
    
    // Start is called before the first frame update

    void Start()
    {
        Luz2.SetActive(false);
        LuzPorta = false;
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Ponteiro")
        {
            LuzPorta = true;
            Luz2.SetActive(true);
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Ponteiro")
        {
            LuzPorta = false;
            Luz2.SetActive(false);
        }
    }
    void Update()
    {
        if (LuzPorta == true)
        {
            oaawnoaawn.SetActive(true);
            Door2.transform.position = new Vector3 (530 , 8 - 12f , -292);
            Destroy(Door2.gameObject);
            Destroy(oaawnoaawn.gameObject);
        }
        else
        {
            oaawnoaawn.SetActive(false);
            Door2.transform.position = new Vector3(530, 8 , -292); ;
            
           
        }
    }

}
