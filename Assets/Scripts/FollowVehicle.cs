using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = vehicle.transform.position + offset;
    }
}
