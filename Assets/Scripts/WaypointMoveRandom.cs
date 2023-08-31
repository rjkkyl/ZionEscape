using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMoveRandom : MonoBehaviour
{
  
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    

    [SerializeField] float speed = Random.Range(0, 10) ;
    

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length) {

                currentWaypointIndex = 0;
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
