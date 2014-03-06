using UnityEngine;
using System.Collections;

public class birdMovement : MonoBehaviour {

    int horizontalVelocity;
    int jumpVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 7, 2);
        }
        else
        {
            rigidbody.velocity = new Vector3(0, rigidbody.velocity.y, 2);
        }
	
	}
}
