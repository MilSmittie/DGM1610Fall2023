using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.00f;
    public float lowBounds = -25.00f;
    // Start is called before the first frame update

    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBounds)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("+1 Coin");
            Destroy(gameObject);
        }
        
    }
}

