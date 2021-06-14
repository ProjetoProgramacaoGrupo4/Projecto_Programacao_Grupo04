using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    [SerializeField] NavMeshAgent agente;
    Transform alvo;
   


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
     
        agente.destination = alvo.position; 
    }

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

            
            }
        }
 }

