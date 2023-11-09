using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idObj);
        Debug.Log(other.GetComponent<IDContainerBehaviour>().idObj);
    }
}
