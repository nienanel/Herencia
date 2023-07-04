using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BaseMovement[] MovingObjects;

    private void Start()
    {
        MovingObjects = FindObjectsOfType<BaseMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var objeto in MovingObjects)
            {
                objeto.StartMovement();
            }
        }
    }
}
