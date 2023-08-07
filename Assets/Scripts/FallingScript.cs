using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingScript : MonoBehaviour
{
    //Variables go here
    public int score;
    public Vector3 startPos;
    Rigidbody rb;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.y < -1.5f)
        {
            transform.position = startPos;
            rb.velocity = Vector3.zero; //changes the float values to zero
        }
        */
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Reset")
        {
            gameManager.ResetPos(startPos, this.gameObject);
        }
    }

}
