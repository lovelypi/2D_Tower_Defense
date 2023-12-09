using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private List<Vector3> points;
    [SerializeField] private Vector3 curPos;
    [SerializeField] private bool isGameStarted;
    
    public Vector3[] Points => points;
    public Vector3 CurPos => curPos;

    private void Start()
    {
        isGameStarted = true;
        curPos = transform.position;
    }

    public Vector3 GetWaypointPosition(int index)
    {
        return CurPos + Points[index];
    }

    // private void OnDrawGizmo()
    // {
    //     if (!isGameStarted && transform.hasChanged)
    //     {
    //         curPos = transform.position;
    //     }
    //
    //     for (int i = 0; i < points.Count; i++)
    //     {
    //         Gizmo.color = Color.red;
    //         Gizmo.DrawWireSphere(points[i] + curPos, 0.5f);
    //
    //         if (i < points.Count - 1)
    //         {
    //             Gizmo.color = Color.green;
    //             Gizmo.DrawLine(points[i] + curPos, points[i + 1] + curPos);
    //         }
    //     }
    // }
}
