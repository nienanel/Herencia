using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : BaseMovement
{
    protected override void Move()
    {
        float speed = 1f;
        float amplitude = 1f;
        float frequency = 1f;
        float time = Time.time * speed;
        float x = Mathf.Sin(time * frequency) * amplitude;
        float z = Mathf.Cos(time * frequency) * amplitude;
        transform.position = new Vector3(x, transform.position.y, z);
        print("movimiento zig zag");
    }
}
