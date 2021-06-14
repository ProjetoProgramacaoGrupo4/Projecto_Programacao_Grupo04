using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float salto = Mathf.PingPong(Time.time, 3);
        if (salto <= 0.5) salto = 0.5f;
        transform.position = new Vector3(transform.position.x, salto , transform.position.z);
    }
}
