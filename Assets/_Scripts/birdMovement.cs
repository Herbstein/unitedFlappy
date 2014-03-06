using UnityEngine;
using System.Collections;

public class birdMovement : MonoBehaviour {

    int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 7, 0);
        }

        transform.Translate(new Vector3(0, 0, 3) * Time.deltaTime, Space.World);
	
	}
}
