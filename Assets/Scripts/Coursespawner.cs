using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coursespawner : MonoBehaviour {
    //So, TIL that you can copy Gameobjects while a game is running in Unity
    //I've also been tapping out how I want the course to be according to the music
    //Sooo, what I'm planning to do with this code is instantiate new instances of the Lantern Gameobject where the player is....
    //In order to save time on creating an entire course by hand
    public GameObject lanternPrefab;
    Lanternsmasher smasher;

	// Use this for initialization
	void Start () {
        smasher = GetComponent<Lanternsmasher>();
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.Space)) && (smasher.overEnemy == false))
        { //if the spacebar is pressed, and player not over a lantern
            GameObject lantern = Instantiate(lanternPrefab);   //Mafe a gameObject from the prefab, store a reference to it in the newBullet var
            lantern.transform.position = new Vector2(transform.position.x, transform.position.y);

            Rigidbody2D rb = lantern.GetComponent<Rigidbody2D>(); //set rb to a reference to the Rigidbody2D on the newBullet gameObject
        }

    }
}
