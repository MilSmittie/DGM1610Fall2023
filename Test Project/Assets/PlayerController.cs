using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    private void Start()
    {
        // Get a reference to the CharacterController component.
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Get player input for movement.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input and player rotation.
        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 rightMovement = transform.right * horizontalInput;

        // Calculate the movement direction vector.
        moveDirection = (forwardMovement + rightMovement).normalized * moveSpeed;

        // Check for jump input and if the player is grounded.
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
        }

        // Apply gravity.
        if (!controller.isGrounded)
        {
            moveDirection.y = gravity * Time.deltaTime;
        }

        // Apply movement to the CharacterController.
        controller.Move(moveDirection * Time.deltaTime);

        // Apply jump if the player is jumping.
        if (isJumping)
        {
            moveDirection.y = jumpForce;
            isJumping = false; // Reset the jump flag.
        }
    }
}