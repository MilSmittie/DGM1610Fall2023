using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30;
    public float lowBounds = -10;
    // Start is called before the first frame update
    void Awake()
    {
        //Time.timeScale = 1.0f;
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
            //Time.timeScale = 0;
        }
    }
}
