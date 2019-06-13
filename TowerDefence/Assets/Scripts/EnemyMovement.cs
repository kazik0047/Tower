using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private float waypointCheckAccuracy;
    private List<Transform> WayPoints;
    
    private Rigidbody2D myRigidbody;
    private Vector3 direction;

    private int wayPointIndex;

    void Start()
    {
        WayPoints = FindObjectOfType<WaypointManager>().WayPoints;
        myRigidbody = GetComponent<Rigidbody2D>();
        transform.position = FindObjectOfType<WaypointManager>().startingPoint.position;
        Debug.Log("transform. position = " + transform.position);
    }

    void FixedUpdate()
    {
        direction = WayPoints[wayPointIndex].position - transform.position;
        direction = direction.normalized;
        myRigidbody.AddForce(direction * speed);
        ChangeWaypoint();
        //Debug.Log(wayPointIndex + "direction = " + direction + "transform. position" + transform.position + 
        //"waypoints position" + WayPoints[wayPointIndex].position);
        //CheckLastWaypoint();  ostatni waypoint do nabijania punktów
    }

    private void ChangeWaypoint()
    {
        if (Vector3.Distance(transform.position,WayPoints[wayPointIndex].position) < waypointCheckAccuracy)
        {
            wayPointIndex++;
        }
    }
}
