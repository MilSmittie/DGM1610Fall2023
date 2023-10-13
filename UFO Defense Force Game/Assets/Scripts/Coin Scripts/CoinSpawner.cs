using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float spawnDelay = 0f;
    private float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnCoin()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //spawns indexed ufo from array on a random location on x axis
        Instantiate(coin, spawnPos, coin.transform.rotation);
    }
}