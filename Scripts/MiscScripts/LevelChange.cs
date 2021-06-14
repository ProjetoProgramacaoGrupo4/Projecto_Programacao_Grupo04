using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            SceneManager.UnloadSceneAsync("Level1");
            SceneManager.LoadScene("Level2");
        }
    }

}
