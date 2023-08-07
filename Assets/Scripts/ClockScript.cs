using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ClockScript : MonoBehaviour
{
    public float timeRemaining;
    int minutes;
    int seconds;
    public TMP_Text timer;

    // Start is called before the first frame update
    void Start()
    {
        //timeRemaining = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
    }

    void CountDown()
    {
        if(timeRemaining > 0f)
        {
            //Count down
            timeRemaining -= Time.deltaTime;
            minutes = Mathf.FloorToInt(timeRemaining/60f);
            seconds = Mathf.RoundToInt(timeRemaining % 60f);

            if(seconds < 10)
            {
                timer.text = "Time left " + minutes + ":0" + seconds;
            }
            else
            {
                timer.text = "Time left " + minutes + ":" + seconds;
            }
        }
        else
        {
            timeRemaining = 0;
            timer.text = "Time left 0:00";
            TimeIsUp();
        }
    }

    private void TimeIsUp()
    {
        Debug.Log("Time is up!");
    }
}
