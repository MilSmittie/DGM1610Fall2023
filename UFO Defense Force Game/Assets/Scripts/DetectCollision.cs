using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }

            if (other.gameObject.tag == "lazer")
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
    }
}
