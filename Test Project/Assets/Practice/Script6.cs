using UnityEngine;
using System.Collections;

public class Script6 : MonoBehaviour
{
    int cupsInTheSink = 4;


    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}