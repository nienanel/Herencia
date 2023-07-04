using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovement : BaseMovement
{
    public float amplitude = 1f; 
    public float frequency = 1f; 

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    protected override void Move()
    {
        float x = initialPosition.x + Mathf.Sin(Time.time * frequency) * amplitude;
        float z = initialPosition.z + Mathf.Cos(Time.time * frequency) * amplitude;

        transform.position = new Vector3(x, initialPosition.y, z);
    }
}
