using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleMesh : MonoBehaviour
{
    public int accuracy = 100;
    public float radius = 1.0f;

    void Start()
    {
        //根据精确度，把圆描述成周长上的点
        //已知角度m，圆上点的坐标分别是（r*cos，r*sin）
        Vector2[] vertices2D = new Vector2[this.accuracy];
        for (int i = 0; i < this.accuracy; i++)
        {
            float angle = 2 * Mathf.PI / this.accuracy * i;
            vertices2D[i] = new Vector2(this.radius * Mathf.Cos(angle), this.radius * Mathf.Sin(angle));

        }


        //2D多边形割三角形算法，来源http://wiki.unity3d.com/index.php/Triangulator
        Triangulator2D tr = new Triangulator2D(vertices2D);
        int[] indices = tr.Triangulate();

        //映射到三维空间当中的点
        Vector3[] vertices = new Vector3[vertices2D.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = new Vector3(vertices2D[i].x, vertices2D[i].y, 0);
        }

        //创建Mesh
        Mesh msh = new Mesh();
        msh.vertices = vertices;
        msh.triangles = indices;

        //设置Mesh
        gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.AddComponent<MeshFilter>();
        filter.mesh = msh;
    }
}
