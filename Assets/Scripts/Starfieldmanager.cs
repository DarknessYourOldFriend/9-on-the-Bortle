using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfieldmanager : MonoBehaviour {
    public ParticleSystem starfield;
    public ParticleSystem.EmissionModule emission;
    public Lanternsmasher smasher;
    public float decayRate = 20;
    public bool triggered;
    // Use this for initialization
    void Start () {
        starfield = GetComponent<ParticleSystem>();
        emission = starfield.emission;
    }
	
	// Update is called once per frame
	void Update () {
		if ((smasher.killerTrigger == true) && (triggered == false))
        {
            decayRate -= 5;
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(decayRate);
            triggered = true;
        }
        else if (smasher.killerTrigger == false)
        {
            triggered = false;
        }
	}
}
