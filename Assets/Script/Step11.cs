using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step11 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input for horizontal and vertical movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply force to the Rigidbody based on input
        if (moveDirection != Vector3.zero)
        {
            rb.AddForce(moveDirection * moveSpeed, ForceMode.Force);
        }
    }
}
