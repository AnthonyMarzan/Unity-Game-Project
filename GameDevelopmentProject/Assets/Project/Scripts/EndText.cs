using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{
    public Text firstText, secondText, thirdText;
    // Start is called before the first frame update
    void Start()
    {
        //Ending text format
        int totalScore = Singleton.Instance._level1score + Singleton.Instance._currentScore;
        float totalTime = Singleton.Instance._level1time + Singleton.Instance._time;
        firstText.text = "Level 1 --- Score:  " + Singleton.Instance._level1score + "    Time:  " + Singleton.Instance._level1time;
        secondText.text = "Level 2 --- Score:  " + Singleton.Instance._currentScore + "    Time:  " + Singleton.Instance._time;
        thirdText.text = "Total --- Score:  " + totalScore + "    Time:  " + totalTime;

        //resets the cursor status so taht we can use it at the end menu
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
