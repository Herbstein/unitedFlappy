using UnityEngine;
using System.Collections;

public class killChecker : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    // Called on trigger enter
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "pipe")
        {
            killBird();
        }
    }

    void killBird()
    {
        Time.timeScale = 0;  
    }
}
