using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingColor : MonoBehaviour
{
    public Color startColor = Color.yellow;
    public Color endColor = Color.white;
    [Range(0,10)]
    public float speed = 1.0f;

    Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    void Update()
    {
        ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }


}
