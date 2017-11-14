using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfieldmanager : MonoBehaviour {
    public ParticleSystem starfield;
    public ParticleSystem.EmissionModule emission;
    public Lanternsmasher smasher;
    // Use this for initialization
    void Start () {
        starfield = GetComponent<ParticleSystem>();
        emission = starfield.emission;
    }
	
	// Update is called once per frame
	void Update () {
		if (smasher.starKilling == true)
        {
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(10.0f);
        }
	}
}
