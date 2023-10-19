using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    public AudioClip coinSound;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(collision.gameObject);
        }
    }
}
