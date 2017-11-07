using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform followObject; //Slide object into this slot to use their transform
    public float offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 currentPosition = transform.position;

        //Mathf.Lerp is a function for blending two values some amount
        //if I give it the parameters (a,b,0.5f) then it will return a 50% blend of a and b
        //if I give it the parameter (a,b,0.1f) then it will be 10% a and 90% b
        //here we use it to make the camera go 50% of the way to the followObject's position every frame.
        currentPosition.x = Mathf.Lerp(currentPosition.x, followObject.position.x + offset, 0.25f);

        //now that we've modified the position, we can copy the value back to the transform
        transform.position = currentPosition;

    }
}
