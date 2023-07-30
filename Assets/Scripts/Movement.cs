using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float h;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;    
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("You pressed the T key.");
        }
        */

        h = Input.GetAxis("Horizontal");
        var direction = new Vector3(h, 0, 0);
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
