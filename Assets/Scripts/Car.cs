using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    protected override void Move()
    {
        base.Move();

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
