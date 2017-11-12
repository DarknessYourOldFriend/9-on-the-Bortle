using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lanternsmasher : MonoBehaviour
{
    Collider2D thisCollision;
    public bool overEnemy;
    public GameObject collidedWith;


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
    }
    void OnTriggerExit2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy") //Switches trigger to go back to false
        {
            Debug.Log("It works, just exited:" + thisCollision.name);
            overEnemy = false;
        }
    }
}
