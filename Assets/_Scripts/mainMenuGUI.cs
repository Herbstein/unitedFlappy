using UnityEngine;
using System.Collections;

public class mainMenuGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 100, 25), "Play Game"))
        {
            Application.LoadLevel(1);
        }
    }
}
