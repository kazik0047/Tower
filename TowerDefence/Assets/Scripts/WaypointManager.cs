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

        //IncreaseWaypointsPosition();
    }

    //private void IncreaseWaypointsPosition()
    //{
    //    WayPoints[0] = startingPoint;
    //    for (int i = 1; i < WayPoints.Count -1; i++)
    //    {
    //        WayPoints[i] = WayPoints[i + 1];
    //        Debug.Log("zxdciuhv");
    //    }
    //}
}

