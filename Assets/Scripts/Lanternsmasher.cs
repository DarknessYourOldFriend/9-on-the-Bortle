using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanternsmasher : MonoBehaviour
{
    Collider2D thisCollision;
    public bool overEnemy = false;
    Playermovement movement;

    void Start()
    {
        thisCollision = GetComponent<Collider2D>();
        movement = GetComponent<Playermovement>();
    }
    void OnTriggerStay2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy") //&& (Input.GetKeyDown(KeyCode.Space)))
        {
            Debug.Log("The Smasher hit " + thisCollision.name);
            overEnemy = true;
        }
        }
    }

