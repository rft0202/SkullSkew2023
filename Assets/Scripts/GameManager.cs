using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject skullDisplay;
    public Sprite[] skulls;
    public string[] chosenSkullList;
    public string chosenSkullName;
    public TMP_Text[] scoreText;

    // Start is called before the first frame update
    void Start()
    {
        PickSkull();
    }

    public void PickSkull()
    {
        int imgCount = skulls.Length;
        int chosenSkull = Random.Range(0, imgCount);
        skullDisplay.GetComponent<Image>().sprite = skulls[chosenSkull];
        chosenSkullName = chosenSkullList[chosenSkull];
    }

    public void ResetPos(Vector3 startPos, GameObject obj)
    {
        var restartPos = new Vector3(Random.Range(-3, 3), startPos.y, startPos.z);
        obj.transform.position = restartPos;
        obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
        obj.GetComponent<Rigidbody>().AddForce(0, Random.Range(1, 5), 0, ForceMode.Impulse);
    }

    public void AddScore(int color, int score)
    {
        scoreText[color].text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
