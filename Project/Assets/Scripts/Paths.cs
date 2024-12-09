using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints = null;

    public int WaypointLengh
    {
        get
        {
            return waypoints.Length;
        }
    }

    public Vector3 GetPosition(int index)
    {
        return waypoints[index].position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
        }

        //Gizmos.DrawLine(waypoints[waypoints.Length - 1].transform.position, waypoints[0].transform.position);
    }
}