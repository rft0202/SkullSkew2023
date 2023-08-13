using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TallyScore : MonoBehaviour
{
    int redScore;
    int yellowScore;
    int greenScore;
    int blueScore;
    int totalScore;
    public TMP_Text redText;
    public TMP_Text yellowText;
    public TMP_Text greenText;
    public TMP_Text blueText;
    public TMP_Text totalText;

    // Start is called before the first frame update
    void Start()
    {
        redScore = PlayerPrefs.GetInt("red");
        yellowScore = PlayerPrefs.GetInt("yellow");
        greenScore = PlayerPrefs.GetInt("green");
        blueScore = PlayerPrefs.GetInt("blue");
        totalScore = (redScore + yellowScore + greenScore + blueScore) + 10;
        FinalScore();
    }

    void FinalScore()
    {
        redText.text = "Red Collected        " + redScore.ToString();
        yellowText.text = "Yellow Collected        " + yellowScore.ToString();
        blueText.text = "Blue Collected        " + blueScore.ToString();
        greenText.text = "Green Collected        " + greenScore.ToString();
        totalText.text = "Total Score        " + totalScore.ToString();
    }
}
