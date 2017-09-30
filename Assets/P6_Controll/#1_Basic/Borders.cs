using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    private EdgeCollider2D edge;

    void CreateBorders()
    {
        this.edge = gameObject.AddComponent<EdgeCollider2D>();//碰撞对象

        //5个顶点才能连成一个4边行，最后一个顶点需要和第一个点重合
        Vector2[] points = new Vector2[5];
        points[0] = new Vector2(-18, -18);
        points[1] = new Vector2(18, -18);
        points[2] = new Vector2(18, 18);
        points[3] = new Vector2(-18, 18);
        points[4] = new Vector2(-18, -18);
        this.edge.points = points;
    }

    // Use this for initialization
    void Start()
    {
        this.CreateBorders();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {

    }
}
