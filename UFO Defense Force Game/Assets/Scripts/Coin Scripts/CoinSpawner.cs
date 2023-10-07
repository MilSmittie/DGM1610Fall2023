using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //declare variables
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Transform spawner;
    public GameObject coin;

    void Start()
    {
        //call SpawnObject repeatedly
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        //Create coin at random position retaining object's rotation
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 0, 10);
        Instantiate(coin, randomSpawnPosition, transform.rotation);
        
        //Stop spawning
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
