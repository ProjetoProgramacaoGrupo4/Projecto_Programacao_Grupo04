using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject sprite;
    private Vector2 moveInput;
   


    // Start is called before the first frame update
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
           
            moveInput.x = Input.GetAxis("Horizontal");
            moveInput.y = Input.GetAxis("Vertical");
            sprite.transform.Rotate(0, -270, 0);
             
        }
    }
}
