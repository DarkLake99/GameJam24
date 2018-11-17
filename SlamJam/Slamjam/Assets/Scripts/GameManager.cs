using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //Pause Menu
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public KeyCode pauseButton;
    //Use this for initialization
     // Update is called once per frame
    void Update()
    {
        //Pause Menu
        if (Input.GetKey(pauseButton))
        {
            //pause the game
            if (gameIsPaused == false)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                gameIsPaused = true;
            }

        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
 
}
