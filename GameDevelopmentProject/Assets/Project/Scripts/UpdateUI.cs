using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateUI : MonoBehaviour {

    //Creates 3 labels on the top left corner that displays the Score, Level and elapsed Time
    void OnGUI()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(3))
        {

            GUI.Label(new Rect(120, 40, 200, 100), "Score: " + Singleton.Instance._currentScore);
            GUI.Label(new Rect(120, 55, 100, 100), "Level: " + Singleton.Instance._level);
            GUI.Label(new Rect(120, 70, 150, 100), "Elapsed Time: " + Singleton.Instance._time);
        }
    }
}
