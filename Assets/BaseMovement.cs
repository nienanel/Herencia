using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    protected bool puedeMoverse;

    protected virtual void Update()
    {
        if (puedeMoverse)
        {
            Move();
        }
    }

    public virtual void StartMovement()
    {
        puedeMoverse = true;
    }

    protected virtual void Move()
    {
        // Implementa el movimiento específico de cada objeto en las clases derivadas
    }
}
