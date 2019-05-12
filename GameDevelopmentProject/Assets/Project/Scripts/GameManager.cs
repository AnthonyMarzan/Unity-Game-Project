using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private float _timePassed;

    public float TimePassed
    {
        get { return _timePassed; }
        set { _timePassed = value; }
    }

    public float maxTimeSeconds = 5 * 60; // In seconds.


    void Start()
    {
        TimePassed = 0;
    }

    void Update()
    {
        TimePassed += Time.deltaTime;

        if (TimePassed >= maxTimeSeconds)
        {
            TimePassed = 0; // maxTimeSeconds;
            SceneManager.LoadScene(0);
        }

        //Updates Level depending on scene
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0))
        {


            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
            {
                Singleton.Instance.UpdateLevel(1);
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
            {
                Singleton.Instance.UpdateLevel(2);
            }

            Singleton.Instance.GetTime(_timePassed);
        }
    }

    //when the play or replay button is pressed, resets the score and loads the level 1 scene
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Singleton.Instance._currentScore = 0;
    }

    //when the exit button is pressed, quits the game
    public void ExitGame()
    {
        Application.Quit();
    }
}
