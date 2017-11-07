using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanternsmasher : MonoBehaviour {

    void OnTriggerStay2D(Collider2D thisCollision)
    {
        if (Input.GetKey(KeyCode.Space) && (thisCollision.collider.tag == "Enemy"))
        {
            Debug.Log("hit " + thisCollsion.collider.name);
            Destroy(thisCollision.gameObject);
        }
    }
