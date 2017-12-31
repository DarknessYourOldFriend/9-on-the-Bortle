using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playermovement : MonoBehaviour
{
    //public float playerSpeed = 1.0f; //Speed of player input
    public float horizonSpeed = 1.0f; //Speed of horizontal auto movement
    public float warpUp = 3.0f; //Position of player changes without physics
    public float warpDown = -3.0f;
    public GameObject explosion;
    public bool explosions = true;
    public float horizonSpeedup0 = 10.0f;
    public float horizonSpeedup = 10.0f;
    private float playerPosition;
    //public ParticleSystem starfield;
    //public ParticleSystem.EmissionModule emission;
    Lanternsmasher smasher;
    //Playerlightcontrol lighter;
    Rigidbody2D rb;
    AudioSource song;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        smasher = GetComponent<Lanternsmasher>();
        song = GetComponent<AudioSource>();
        //starfield = GetComponent<ParticleSystem>();
        //emission = GetComponent<ParticleSystem.EmissionModule>();
        smasher.overEnemy = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(horizonSpeed * Time.deltaTime, 0, 0); //Player is contantly moving horizontally
    }

    void Update()
    {
        playerPosition = GameObject.Find("Player").transform.position.y;
        //var emission = starfield.emission;

        if (Input.GetKeyDown(KeyCode.UpArrow) && (playerPosition != 3)) //!= 3 keeps player from moving too far up (can't believe I didn't think of that sooner)  
        {
            //rb.velocity = new Vector3(horizonSpeed, +playerSpeed, 0);
            //Movement without Physics
            // uses Simplelanechanger script, but horizontal instead of vertical
            Vector3 position = transform.position;

            position.y += warpUp;
            transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && (playerPosition != -3)) //&& (playerPosition != 0))
        {
            //rb.velocity = new Vector3(horizonSpeed, -playerSpeed, 0);

            //Movement without Physics
            Vector3 position = transform.position;
            position.y -= warpDown;
            transform.position = position;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && (smasher.overEnemy == true) && (explosions == true)) //Pressing space when player is over a lantern destroys it
        {
            Debug.Log("It works, just popped:" + smasher.collidedWith.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(smasher.collidedWith.gameObject);
            //lighter.playerPressed = true;
        }
        if ((smasher.songCue == true) && (song.isPlaying == false))
        {
            song.Play();
        }

        if (smasher.speedUp0 == true)  //Have two collider triggers tagged as "speedUp" and "speedUp0", this changes horizon speed
        {
            horizonSpeed += horizonSpeedup0 * Time.deltaTime;

        if (smasher.speedUp == true)
            {
                horizonSpeed += horizonSpeedup * Time.deltaTime;
            }

            // if ((Input.GetKeyDown(KeyCode.Space)) && (gamestart.preGamestate == true))
            //{
            //  gamestart.preGamestate = false;
            //}
        }
    }
}
    //if (Input.GetKeyDown(KeyCode.Space))
      //  {
        //    lighter.playerPressed = true;   
        //}
        //else if (smasher.overEnemy == false)
        //{
            //Debug.Log("Update was the thing you needed to do");
        //}

    //}
//}

