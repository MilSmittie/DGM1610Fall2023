using UnityEngine;
using System.Collections;

public class Script18 : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}