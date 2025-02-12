using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class CarNavigator : MonoBehaviour
{
    [Header("Car Info")]
    public float movingSpeed;
    public float turningSpeed = 100f;
    public float stopSpeed = 1f;
    public GameObject sensor;
    float detectionRange = 10f;

    [Header("Destination Var")]
    public Vector3 destination;
    public bool destinationReached;
    public ThirdPersonController player;
    // public Animator animator;
    // private float waypointTimeout = 30f;
    // public float currentTimeout = 0f;

    private void Update()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(sensor.transform.position, sensor.transform.forward, out hitInfo, detectionRange))
        {
            Debug.Log(hitInfo.transform.name);

            CharNavigator CharacterNPC = hitInfo.transform.GetComponent<CharNavigator>();
            ThirdPersonController playerBody = hitInfo.transform.GetComponent<ThirdPersonController>();

            if (CharacterNPC != null)
            {
                movingSpeed = 0f;
                return;
            }
            else if (playerBody != null)
            {
                movingSpeed = 0f;
                return;
            }
        }
        Drive();
    }

    public void Drive()
    {
        movingSpeed = 5f;

        if (transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;
            float destinationDistance = destinationDirection.magnitude;

            if (destinationDistance >= stopSpeed)
            {
                destinationReached = false;
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation,
                turningSpeed * Time.deltaTime);

                transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
            }
            else
            {
                destinationReached = true;
            }
        }
    }

    public void LocateDestination(Vector3 destination)
    {
        this.destination = destination;
        destinationReached = false;
        // currentTimeout = 0f;
    }
}
