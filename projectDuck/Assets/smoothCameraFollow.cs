using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offest;
     void LateUpdate()
    {
        Vector3 desiredPoistion = target.position + offest;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPoistion, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
