using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.00f;
    public float lowBounds = -10.00f;
    public GameManager gameManager; //reference game manager

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //reference game manager script
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
    }
}
