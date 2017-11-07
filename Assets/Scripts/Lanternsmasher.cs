using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanternsmasher : MonoBehaviour
{
    Collider2D thisCollision;

    void Start()
    {
        thisCollision = GetComponent<Collider2D>();
    }

    void OnTriggerStay2D(Collider2D thisCollision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Enemy")
        {
            Debug.Log("The Smasher hit " + thisCollision.name);
            Destroy(thisCollision.gameObject);
        }
    }
}
