using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour {
    public GameObject portal;
    public Transform[] spawnLocations;
    private float timespawns;
    public float timeBTWspawns;
    public GameObject UISystem;
    // Use this for initialization
    private void Start()
    {
        timespawns = timeBTWspawns;
    }
    // Update is called once per frame
    void Update () {
        if (timespawns <= 0)
        {
            int randLocaInd = Random.Range(0, spawnLocations.Length);
            Instantiate(portal, spawnLocations[randLocaInd].position, Quaternion.identity);
            Instantiate(UISystem, spawnLocations[randLocaInd].position, Quaternion.identity);
            timespawns = timeBTWspawns;
        }
        else
        {
            timespawns -= Time.deltaTime;
        }
    }
}
