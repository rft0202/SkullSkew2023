using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CauldronScore : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        other.GetComponent<FallingScript>().ResetPos();
        scoreText.text = "Score: " + score.ToString();
        Debug.Log(score);
    }
}
