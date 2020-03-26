using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed;
    public bool movingRight = true;
    public float SwitchDistance = 2;

    public int currentWaypoint;
    public List<GameObject> Waypoints = new List<GameObject>();


    // Update is called once per frame
    void Update()
    {

        if(Vector2.Distance(this.transform.position, Waypoints[currentWaypoint].transform.position) >= SwitchDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);
        }
        else
        {
            currentWaypoint++;

            if (currentWaypoint > Waypoints.Count - 1)
                currentWaypoint = 0;
        }


        //if (movingRight == true)
        //{

        //    transform.position = Vector2.MoveTowards(transform.position, WayPointA.transform.position, speed * Time.deltaTime);

        //    if (Vector2.Distance(this.transform.position, WayPointA.transform.position) <= SwitchDistance)
        //    {
        //        movingRight = false;
        //    }
        //}
        //else
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, WayPointB.transform.position, speed * Time.deltaTime);

        //    if (Vector2.Distance(this.transform.position, WayPointB.transform.position) <= SwitchDistance)
        //    {
        //        movingRight = true;
        //    }
        //}


    }
}

