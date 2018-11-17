using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //Pause Menu
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public KeyCode pauseButton;
    //Weapons
    public GameObject[] weapons;
    public Transform[] spawnWeaLocations;
    private float timeWeaSpawns;
    public float timeWeaBTWs;
    //Use this for initialization
    private void Start()
    {
        timeWeaSpawns = timeWeaBTWs;
    }
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

        //weapons
        if (timeWeaSpawns <= 0)
        {
            int randWeaInd = Random.Range(0, weapons.Length);
            int randWeaLocInd = Random.Range(0, spawnWeaLocations.Length);
            Instantiate(weapons[randWeaInd], spawnWeaLocations[randWeaLocInd].position, Quaternion.identity);
        }
        else
        {
            timeWeaSpawns -= Time.deltaTime;
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
 
}
