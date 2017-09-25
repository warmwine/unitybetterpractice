using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Image_With_Mesh : MonoBehaviour
{
    public Texture texture = null;
    private Mesh mesh = null;
    private MeshRenderer meshRenderer = null;

    void AddComponents()
    {
        //添加必要组件
        this.mesh = gameObject.AddComponent<MeshFilter>().mesh;//网格对象
        this.meshRenderer = gameObject.AddComponent<MeshRenderer>();//网格渲染器
    }

    void CreateMesh()
    {
        //矩形由4个顶点组成。
        Vector3[] vertexes = new Vector3[4];
        vertexes[0] = new Vector3(0, 0, 0);
        vertexes[1] = new Vector3(1, 0, 0);
        vertexes[2] = new Vector3(1, 1, 0);
        vertexes[3] = new Vector3(0, 1, 0);
        this.mesh.vertices = vertexes;

        //矩形是由2个三角形组成的。
        //注意坐标系的左手螺旋定律来决定三角形的正面朝向是正z轴还是负z轴。
        //如果是背面朝向摄影机，该三角形是不会被渲染的。
        int[] triangles = new int[6];
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        triangles[3] = 0;
        triangles[4] = 3;
        triangles[5] = 2;
        this.mesh.triangles = triangles;
    }

    void SetImageAsTheMaterial()
    {
        //设置纹理，该纹理在editor中对本类的texture成员赋值得到。
        //todo uv赋值
        meshRenderer.material.mainTexture = this.texture;
    }


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        //按照顺序运行时创建网格(Mesh)来渲染图片
        this.AddComponents();
        this.CreateMesh();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {

    }
}
