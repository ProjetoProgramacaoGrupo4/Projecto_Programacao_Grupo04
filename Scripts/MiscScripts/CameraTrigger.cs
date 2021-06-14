using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;
    public CinemachineVirtualCamera labCamera;
    


    void OnTriggerEnter(Collider hit)
     {
            if (hit.tag == "Player")
            {
            labCamera.Priority++;
            
            } 
        }
  





}

