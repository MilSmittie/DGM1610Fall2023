using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyOutOfBounds : MonoBehaviour
{
    public float lowBounds = -10.00f;
    // Start is called before the first frame update
    void Awake()
    {
        //Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lowBounds)
        {
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
