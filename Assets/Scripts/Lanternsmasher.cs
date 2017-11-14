using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lanternsmasher : MonoBehaviour
{
    Collider2D thisCollision;
    public bool overEnemy;
    public bool songCue = false;
    public GameObject collidedWith;
    public bool isPlaying;
    public bool speedUp0;
    public bool speedUp;
    public bool starKilling = false;
    public bool killerTrigger1 = false;
    public bool killerTrigger2 = false;
    public bool killerTrigger3 = false;
    public bool killerTrigger4 = false;
    Starfieldmanager starfield;


    void Start()
    {
        thisCollision = GetComponent<Collider2D>();
        starfield = GetComponent<Starfieldmanager>();
    }
    void update()
    {
        if ((overEnemy == true) && (Input.GetKeyDown(KeyCode.Space))) //Tells the square under player to be destroyed
            Destroy(thisCollision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy") //Grabs the name of object, says player is going ove it
        {
            Debug.Log("The Smasher hit " + thisCollision.name);
            collidedWith = thisCollision.gameObject;
            overEnemy = true;
        }

        if (thisCollision.GetComponent<Collider2D>().tag == "Songcue")
        {
            songCue = true;
            isPlaying = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Speedup")
        {
            speedUp = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Speedup0")
        {
            speedUp0 = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller1")
        {
            killerTrigger1 = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller2")
        {
            killerTrigger2 = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller3")
        {
            killerTrigger3 = true;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller4")
        {
            killerTrigger4 = true;
        }
    }
    void OnTriggerExit2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy") //Switches trigger to go back to false
        {
            Debug.Log("It works, just exited:" + thisCollision.name);
            overEnemy = false;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Songcue")
        {
            songCue = false;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller1")
            {
            killerTrigger1 = false;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller2")
        {
            killerTrigger2 = false;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller3")
        {
            killerTrigger3 = false;
        }
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller4")
        {
            killerTrigger4 = false;
        }
    }
}
