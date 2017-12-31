using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfieldmanager : MonoBehaviour {
    public ParticleSystem starfield;
    public ParticleSystem.EmissionModule emission;
    public ParticleSystem.MainModule starSpeed;
    public Lanternsmasher smasher;
    public float simSpeed;
    public float speedUprate = 0.01F;
    public float speedUplimit = 2F;
    public float speedUplimit0 = 3F;
    public float decayRate;
    public bool triggered;
    // Use this for initialization
    void Start() {
        starfield = GetComponent<ParticleSystem>();
        emission = starfield.emission;
        starSpeed = starfield.main; //simulationSpeed is in main module, have to access Main Module first
    }

    // Update is called once per frame
    void Update() {
        if (smasher.killerTrigger1 == true)
        {
            decayRate = 15;
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(decayRate);
        }
        if (smasher.killerTrigger2 == true)
        {
            decayRate = 10;
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(decayRate);
        }
        if (smasher.killerTrigger3 == true)
        {
            decayRate = 5;
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(decayRate);
        }
        if (smasher.killerTrigger4 == true)
        {
            decayRate = 3;
            emission.rateOverTime = new ParticleSystem.MinMaxCurve(decayRate);
        }
        if ((smasher.speedUp == true) && (starSpeed.simulationSpeed < speedUplimit0))
        {
            Debug.Log("Hit the speed bump, timer up");
            simSpeed += speedUprate * Time.deltaTime;
            starSpeed.simulationSpeed = simSpeed;//Add Simulation Speed here 
            //Going to need to change horizon speed in playermovement to avoid the stuttering effect
            //speeduplimit0 = 2 means that horizon movement should equal 400 to avoid stutter 
        }
        if ((smasher.speedUp0 == true) && (starSpeed.simulationSpeed < speedUplimit))
        {
            simSpeed += speedUprate * Time.deltaTime;
            starSpeed.simulationSpeed = simSpeed;

        }
    }
}
