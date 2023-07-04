using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinealMovement : BaseMovement
{
    protected override void Move()
    {
        print("movimiento lineal");
        float speed = 1f;
        transform.position += new Vector3(speed * Time.deltaTime, 0f, speed * Time.deltaTime);
    }
}
