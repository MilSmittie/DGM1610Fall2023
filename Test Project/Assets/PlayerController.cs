using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    
    public float walkSpeed;
    public float sprintSpeed;
    public float rotationSpeed;
    public float jumpSpeed;
    public float crouchSpeed;
    public float crouchYScale;
    private float speed;
    private float startYScale;
    private float ySpeed;
    private float origionalStepOffset;


    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode crouchKey = KeyCode.LeftControl;

    public MovementState state;
    public enum MovementState
    {
        walking,
        sprinting,
        air
    }

    //Start called before first frame

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        origionalStepOffset = characterController.stepOffset;
    }

    //Update called once per frame

    private void Update()
    {
        StateHandler();
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

        ySpeed += Physics.gravity.y * Time.deltaTime;
        
        if (characterController.isGrounded)
        {
            ySpeed = -0.5f;
            characterController.stepOffset = origionalStepOffset;

            if (Input.GetKey(KeyCode.Space))
            {
                ySpeed = jumpSpeed;
            }
        }
        else
        {
            characterController.stepOffset = 0;
        }

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void StateHandler()
    {
        //Mode Sprinting
        if (characterController.isGrounded && Input.GetKey(sprintKey))
        {
            state = MovementState.sprinting;
            speed = sprintSpeed;
        }

        //Mode Walking
        else if (characterController.isGrounded)
        {
            state = MovementState.walking;
            speed = walkSpeed;
        }

        else
        {
            state = MovementState.air;
        }
    }
}