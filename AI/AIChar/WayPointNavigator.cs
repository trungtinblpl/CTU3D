using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointNagative : MonoBehaviour
{
    [Header("AI Character")]
    public CharNavigator character;
    public Waypoint currentWaypoint;
    int direction;

    private void Awake()
    {
        character = GetComponent<CharNavigator>();
    }

    private void Start()
    {
        direction = Mathf.RoundToInt(Random.Range(0f, 1f));
        character.LocateDestination(currentWaypoint.GetPosition());
    }

    private void Update()
    {
        if (character.destinationReached)
        {
            if (direction == 0)
            {
                if (currentWaypoint.nextWaypoint != null)
                {
                    currentWaypoint = currentWaypoint.nextWaypoint;
                }
                else
                {
                    currentWaypoint = currentWaypoint.previousWaypoint;
                    direction = 1;
                }
            }
            else if (direction == 1)
            {
                if (currentWaypoint.previousWaypoint != null)
                {
                    currentWaypoint = currentWaypoint.previousWaypoint;
                }
                else
                {
                    currentWaypoint = currentWaypoint.nextWaypoint;
                    direction = 0;
                }
            }

            character.LocateDestination(currentWaypoint.GetPosition());
        }
    }
}
