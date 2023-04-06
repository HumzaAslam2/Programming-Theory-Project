using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected int year;

    public int Year
    {
        get
        {
            return year;
        }
        protected set
        {
            if (year < 1769)
            {
                year = 1769;
            }
            else
            {
                year = value;
            }
        }
    }

    [SerializeField] protected float speed = 5;
    [SerializeField] protected float rotationSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
