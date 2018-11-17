using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapons : MonoBehaviour {
    public GameObject[] weapons;
    public Transform[] spawnWeaLocations;
    private float timeWeaSpawns;
    public float timeWeaBTWs;
    // Use this for initialization
    void Start()
    {
        timeWeaSpawns = timeWeaBTWs;
    }

    // Update is called once per frame
    void Update () {
		//weapons
        if (timeWeaSpawns <= 0)
        {
            int randWeaInd = Random.Range(0, weapons.Length);
            int randWeaLocInd = Random.Range(0, spawnWeaLocations.Length);
            Instantiate(weapons[randWeaInd], spawnWeaLocations[randWeaLocInd].position, Quaternion.identity);
            timeWeaSpawns = timeWeaBTWs;
        }
        else
        {
            timeWeaSpawns -= Time.deltaTime;
        }
	}
}
