using UnityEngine;
using System.Collections;

public class Script20 : MonoBehaviour
{
    public GameObject other;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}