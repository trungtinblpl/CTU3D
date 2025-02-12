using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWayPointNavigator : MonoBehaviour
{
    [Header("AI Car")]
    public CarNavigator car;
    public Waypoint currentWaypoint;

    private void Awake()
    {
        car = GetComponent<CarNavigator>();
    }

    private void Start()
    {
        car.LocateDestination(currentWaypoint.GetPosition());
    }

    private void Update()
    {
        if (car.destinationReached)
        {
            currentWaypoint = currentWaypoint.nextWaypoint;
            car.LocateDestination(currentWaypoint.GetPosition());
        }
    }
}
