using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class collisionplayer : MonoBehaviour
{

    public Rigidbody rb;
    public float launchForce;
    [SerializeField] GameObject memoria;
    [SerializeField] GameObject memoria2;
    [SerializeField] GameObject memoria3;
    [SerializeField] GameObject clue;
    float vidas = 3f;
    [SerializeField]
    float lives = 3f;
    float coletavel = 0;
    [SerializeField]
    TextMeshProUGUI vidaTXT;
    [SerializeField]
    TextMeshProUGUI coletavelTXT;




    // Start is called before the first frame update
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Dano")
        {
            lives -= 1;
            vidas -= 1;
            vidaTXT.text = vidas.ToString(); ;

        }
        else if (lives <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (other.gameObject.tag == "Coletavel")
        {
            lives += 2;
            vidas += 2;
            coletavel += 1;
            coletavelTXT.text = coletavel.ToString(); ;
            vidaTXT.text = vidas.ToString(); ;
            Destroy(other.gameObject);
            memoria.SetActive(true);
        }
        

        if (other.gameObject.tag == "Coletavel2")
            {
                lives += 2;
                vidas += 2;
                coletavel += 1;
                coletavelTXT.text = coletavel.ToString(); ;
                vidaTXT.text = vidas.ToString(); ;
                Destroy(other.gameObject);
                memoria2.SetActive(true);
                

            }
            

            if (other.gameObject.tag == "Coletavel3")
            {
                lives += 2;
                vidas += 2;
                coletavel += 1;
                coletavelTXT.text = coletavel.ToString(); ;
                vidaTXT.text = vidas.ToString(); ;
                Destroy(other.gameObject);
                memoria3.SetActive(true);


            }
            

            if (other.gameObject.tag == "Clue")
            {
                lives += 2;
                vidas += 2;
                vidaTXT.text = vidas.ToString(); ;
                Destroy(other.gameObject);
                clue.SetActive(true);


            }
            

            if (other.gameObject.tag == "Trampolim")
            {
                rb.velocity = Vector3.up * launchForce;

            }

            if (other.gameObject.tag == "InstaDano")
            {
                lives -= 3;
                vidas -= 3;
                vidaTXT.text = vidas.ToString(); ;
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver2");
            }



        }
    }







    


