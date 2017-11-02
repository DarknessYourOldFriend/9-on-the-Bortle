using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {
    //public float playerSpeed = 1.0f; //Speed of player input
    public float horizonSpeed = 1.0f; //Speed of horizontal auto movement
    public float warpUp = 3.0f; //Position of player changes without physics
    public float warpDown = - 3.0f;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3(horizonSpeed, 0, 0); //Player is contantly moving horizontally
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rb.velocity = new Vector3(horizonSpeed, +playerSpeed, 0);
            //Movement without Physics
     		Vector3 position = transform.position;
            
            position.y += warpUp;
            transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //rb.velocity = new Vector3(horizonSpeed, -playerSpeed, 0);

            //Movement without Physics
            Vector3 position = transform.position;
            position.y -= warpDown;
            transform.position = position;
        }
        //if (Input.GetKey(KeyCode.Space))
        //{

        //}
        


    }
}
