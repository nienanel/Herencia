using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingMovement :BaseMovement
{
    public float jumpForce = 5f;
    public float jumpInterval = 1f;
    private float nextJumpTime;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    protected override void Update()
    {
        base.Update();

        if (puedeMoverse && Time.time >= nextJumpTime)
        {
            Jump();
            nextJumpTime = Time.time + jumpInterval;
        }
    }

    private void Jump()
    {
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }
}
