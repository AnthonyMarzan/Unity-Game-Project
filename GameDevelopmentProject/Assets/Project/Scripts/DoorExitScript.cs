using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorExitScript : MonoBehaviour
{
    //depending on the scene if green door is reached, load next level or scene
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
            {
                Singleton.Instance.ResetScore(1);
                SceneManager.LoadScene(2);
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
