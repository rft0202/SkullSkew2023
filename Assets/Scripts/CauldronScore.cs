using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CauldronScore : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject[] skullScores;
    public string chosenSkull;
    public AudioClip[] soundFX;
   
    // Start is called before the first frame update
    void Start()
    {
        chosenSkull = gameManager.chosenSkullName;
    }

    private void OnTriggerEnter(Collider other)
    {
        chosenSkull = gameManager.chosenSkullName;
        GetComponent<AudioSource>().PlayOneShot(soundFX[Random.Range(0, soundFX.Length)]);
        SortSkullScore(other.gameObject.tag);
    }

    void SortSkullScore(string objTag)
    {
        int caughtSkull = 0;
        switch(objTag)
        {
            case "green":
                caughtSkull = 0;
                break;
            case "blue":
                caughtSkull = 1;
                break;
            case "red": 
                caughtSkull = 2;
                break;
            case "yellow":
                caughtSkull = 3;
                break;
        }

        if(objTag == chosenSkull)
        {
            //resets position
            gameManager.ResetPos(skullScores[caughtSkull].GetComponent<FallingScript>().startPos, skullScores[caughtSkull]);
            //Increase score proper skull caught
            skullScores[caughtSkull].GetComponent<FallingScript>().score++;
            //Add to HUD score
            gameManager.AddScore(caughtSkull, skullScores[caughtSkull].GetComponent<FallingScript>().score);
            //Pick new skull
            gameManager.PickSkull();
        }
        else
        {
            //wrong skull caught, reset pos
            gameManager.ResetPos(skullScores[caughtSkull].GetComponent<FallingScript>().startPos, skullScores[caughtSkull]);
        }
    }
}
