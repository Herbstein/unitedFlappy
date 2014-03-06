using UnityEngine;
using System.Collections;

public class killChecker : MonoBehaviour {

    bool isPlaying = true;
    bool isPaused = false;
    bool showFailedMenu = false;

    void Awake()
    {
        Time.timeScale = 1;
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider other)
    {

        // Kills the bird if it hits a pipe
        if (other.gameObject.tag == "pipe")
        {
            killBird();
        }
    }

    // Tells the OnGUI function to draw the failed function
    private void killBird()
    {
        showFailedMenu = true;
    }

    void OnGUI()
    {

        if (!isPaused)
        {
            if (GUI.Button(new Rect(10, 10, 100, 25), "Pause Game")) //Adds the Pause Game button, and makes sure the game pauses when it's clicked
            {
                isPaused = true;
                Time.timeScale = 0;
            } 
        }

        if(isPaused)
        {
            if(GUI.Button(new Rect(10, 10, 100, 25), "Resume Game")) //Adds the Resume Game button, and makes sure the game resumes when it's clicked
            {
                isPaused = false;
                Time.timeScale = 1;
            }
        }

        if(showFailedMenu)
        {
            Time.timeScale = 0;

            // Reloads the level, when the retry button is pressed
            if(GUI.Button(new Rect((Screen.width/2) + 55,(Screen.height/2) - 12, 100, 25), "Retry"))
            {
                showFailedMenu = false;
                isPaused = false;
                Application.LoadLevel(Application.loadedLevel);
            }

            // Loads the Main Menu if the Main Menu button is pressed
            if(GUI.Button(new Rect((Screen.width/2)-66, (Screen.height/2) - 12, 100, 25), "Main Menu"))
            {
                Application.LoadLevel(0);
            }
        }
    }
}
