using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    //the parent gameobject of the points
    public Transform waypointParent;
    //the points within the parent object
    private Transform[] points;
    //variable for currnt waypoint
    private int currentWaypoint = 1;
    //the distance from the waypoint where it has been 'reached'
    public float waypointDistance = 0.6f;

    public float speed = 1f;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        //get the points in the parent
        points = waypointParent.GetComponentsInChildren<Transform>();
    }

    void OnDrawGizmos()
    {
        //Make the points visible in unity editor
        points = waypointParent.GetComponentsInChildren<Transform>();
        if (points != null)
        {
            // set gizmo colo to red
            Gizmos.color = Color.red;

            for (int i = 1; i < points.Length -1; i++)
            {
                //loop through
                Transform pointA = points[i];
                Transform pointB = points[i + 1];
                Gizmos.DrawLine(pointA.position, pointB.position);
            }

            for (int i = 1; i < points.Length; i++)
            {
                Gizmos.DrawSphere(points[i].position, waypointDistance);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Get current waypoint
        Transform currentPoint = points[currentWaypoint];

        //Move towards current waypoint using nav mesh
        agent.SetDestination(currentPoint.position);

        //Check if distance between waypoint is close
        float distance = Vector3.Distance(transform.position, currentPoint.position);

        //Switch to next waypoint
        if (distance < waypointDistance)
        {
            currentWaypoint++;
        }
        //If end of points change back to first
        if (currentWaypoint == points.Length)
        {
            currentWaypoint = 1;
        }

    }
}
