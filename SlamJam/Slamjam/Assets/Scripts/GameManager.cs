using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour {
    //Pause Menu
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public KeyCode pauseButton;
    public bool winner=false;
    public GameObject play1win;
    public GameObject play2win;
    private healthPoints health;

    //Use this for initialization
     // Update is called once per frame
    void Update()
    {
        if(winner)
        {
            if (gameObject.tag == "Player 1" && health.hp <=0 )
            {
                play1win.SetActive(true);
            }
            else if(gameObject.tag == "Player 2" && health.hp <= 0)
            {
                play2win.SetActive(true);
            }
        }
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
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        if(sceneIndex==2)
        {
            winner = true;
        }
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
