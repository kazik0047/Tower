using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public Transform startingPoint;

    public GameObject startingWaypoint;

    public List<Transform> WayPoints;

    void Start()
    {
        startingPoint = startingWaypoint.GetComponent<Transform>();
    }
}

