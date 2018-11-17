using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //Pause Menu
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public KeyCode pauseButton;
    //Portal
    public GameObject portal;
    public Transform[] spawnLocations;
    private float timespawns;
    public float timeBTWspawns;
    //Weapons
    public GameObject[] weapons;
    public Transform[] spawnWeaLocations;
    private float timeWeaSpawns;
    public float timeWeaBTWs;
    //Use this for initialization
    private void Start()
    {
        timespawns = timeBTWspawns;
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

        //Portal
        if (timespawns <= 0)
        {
            int randLocaInd = Random.Range(0, spawnLocations.Length);
            Instantiate(portal, spawnLocations[randLocaInd].position, Quaternion.identity);
            timespawns = timeBTWspawns;
        }
        else
        {
            timespawns -= Time.deltaTime;
        }
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
