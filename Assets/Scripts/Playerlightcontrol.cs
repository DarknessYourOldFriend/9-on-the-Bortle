﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playerlightcontrol : MonoBehaviour {
    public bool playerPressed;
    public Light playerLight;
	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        if (playerPressed == true)
    {
        Debug.Log("Playerpressedtrue");
        playerLight.enabled = true;
    }
        else if (playerPressed == false)
        {
            playerLight.enabled = false;
        }


	}
}
