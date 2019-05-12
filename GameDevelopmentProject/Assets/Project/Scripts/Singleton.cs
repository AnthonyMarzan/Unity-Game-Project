using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {

    public static Singleton Instance { get; private set; }

    public float _time;
    public int _currentScore;
    public int _level;
    public int _level1score;
    public float _level1time;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //resets score and updates level score
    public void ResetScore(int number)
    {
        if (number == 1)
        {
            _level1score = _currentScore;
            _level1time = _time;
        }
        _currentScore = 0;
    }

    //update level method
    public void UpdateLevel(int levelNum)
    {
        _level = levelNum;
    }

    //adds to score when orb is taken
    public void AdjustScore(int scoreNum)
    {
        _currentScore = _currentScore + scoreNum;
    }

    //updates the time
    public void GetTime(float timeNum)
    {
        _time = timeNum;
    }

}
