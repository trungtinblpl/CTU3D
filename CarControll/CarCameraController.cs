using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    public Transform carTransform;
    public float distanceBihind = 5f;
    public float height = 2f;
    public float smoothSpeed = 0.1f;

    void LateUpdate()
    {
        Vector3 desiredPosition = carTransform.position - carTransform.forward
        * distanceBihind + Vector3.up * height;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        transform.LookAt(carTransform);
    }
}
