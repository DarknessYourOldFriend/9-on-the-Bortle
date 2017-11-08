using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanternsmasher : MonoBehaviour
{
    public Collider2D thisCollision;
    public bool overEnemy = false;


    void Start()
    {
        thisCollision = GetComponent<Collider2D>();
    }
    void update()
    {
        if ((overEnemy == true) && (Input.GetKeyDown(KeyCode.Space)))
            Destroy(thisCollision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy")
        {
            Debug.Log("The Smasher hit " + thisCollision.name);
            thisCollision = thisCollision;
            overEnemy = true;
            //Destroy(thisCollision.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy")
        {
            Debug.Log("It works, thanks Sparky!");
            overEnemy = false;
        }
    }
}
