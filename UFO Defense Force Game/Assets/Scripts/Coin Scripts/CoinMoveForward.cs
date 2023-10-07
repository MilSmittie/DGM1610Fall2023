using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveForward : MonoBehaviour
{
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
      {
          //Move GameObject forward
          transform.Translate(Vector3.back * Time.deltaTime * speed);
      }
}
