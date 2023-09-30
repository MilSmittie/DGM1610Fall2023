using UnityEngine;
using System.Collections;

public class Script5 : MonoBehaviour
{
    int numEnemies = 3;


    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}