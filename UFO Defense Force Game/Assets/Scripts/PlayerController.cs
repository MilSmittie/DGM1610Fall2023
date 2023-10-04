using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20;
    public float xRange = 20;
    public Transform blaster;
    public GameObject lazer;

    // Update is called once per frame
    void Update()
    {
        //set horisontalInput to recieve values from input
        horizontalInput = Input.GetAxis("Horizontal");

        //Move player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player in bounds
        //left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //If spacebar is pressed, shoot lazer
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create lazer at blaster position retaining object's rotation
            Instantiate(lazer, blaster.transform.position, lazer.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //delete any object with a trigger that hits the player
        Destroy(other.gameObject);
    }
}