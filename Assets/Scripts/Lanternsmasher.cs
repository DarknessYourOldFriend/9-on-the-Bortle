using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanternsmasher : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D thisCollision)
    {
        if (thisCollision.collider.tag == "Enemy")
        {
            Debug.Log("The Smasher hit " + thisCollsion.collider.name);
            Destroy(thisCollision.gameObject);
        }
    }
}
