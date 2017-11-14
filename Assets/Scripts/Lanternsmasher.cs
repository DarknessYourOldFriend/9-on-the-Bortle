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
    public bool speedUp;
    public bool starKilling;


    void Start()
    {
        thisCollision = GetComponent<Collider2D>();
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
        if ((thisCollision.GetComponent<Collider2D>().tag == "Starkiller") && (starKilling != true))
        {
            starKilling = true;
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
        if (thisCollision.GetComponent<Collider2D>().tag == "Starkiller")
            {
            starKilling = false;
        }
    }
}
