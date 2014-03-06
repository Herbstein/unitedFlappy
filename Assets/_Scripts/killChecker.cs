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

    // Called on trigger enter
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pipe")
        {
            killBird();
        }
    }

    private void killBird()
    {
        loadFailMenu();
    }

    private void loadFailMenu()
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

            if(GUI.Button(new Rect((Screen.width/2) + 55,(Screen.height/2) - 12, 100, 25), "Retry")) //Retry button. When pressed, the scene is reloaded
            {
                showFailedMenu = false;
                isPaused = false;
                Application.LoadLevel(Application.loadedLevel);
            }

            if(GUI.Button(new Rect((Screen.width/2)-66, (Screen.height/2) - 12, 100, 25), "Main Menu"))
            {
                Application.LoadLevel(0);
            }
        }
    }
}
