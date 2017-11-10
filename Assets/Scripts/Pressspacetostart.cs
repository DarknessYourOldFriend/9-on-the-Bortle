using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressspacetostart : MonoBehaviour {
    public bool preGamestate = true;
    Rigidbody2D rb;
    //AudioSource song;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        //song = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if (preGamestate == false)
        {
            this.rb.WakeUp();
            //this.song.Play();
        }
    }
}
