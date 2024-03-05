using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step6 : MonoBehaviour
{
    public float moveForce = 10f;

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();

        // Ensure Rigidbody is not affected by gravity
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
