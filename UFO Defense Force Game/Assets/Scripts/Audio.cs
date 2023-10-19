using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip bkgSound; //lazer sound variable

    void Start()
    {
        AudioSource.PlayClipAtPoint(bkgSound, transform.position);
    }
}
