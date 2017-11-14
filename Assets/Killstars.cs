using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killstars : MonoBehaviour {
    public Lanternsmasher smasher;
    public ParticleSystem starfield;

	// Use this for initialization
	void Start () {
        starfield = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (smasher.starKilling == true)
        {
            starfield. particleSystem.emission.rateOverTimeMultiplier = -5;

        }
    }
}
