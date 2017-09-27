using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Mesh mesh = null;
    private MeshRenderer meshRenderer = null;

    void AddComponents()
    {
        //添加必要组件
        this.mesh = gameObject.AddComponent<MeshFilter>().mesh;//网格对象
        this.meshRenderer = gameObject.AddComponent<MeshRenderer>();//网格渲染器
        this.meshRenderer.material = new Material(Shader.Find("Sprites/Default"));//材质
    }

    void CreateMesh()
    {
        //3角形角色由3个顶点组成。
        Vector3[] vertexes = new Vector3[3];
        vertexes[0] = new Vector3(0, 0, 0);
        vertexes[1] = new Vector3(1, 0, 0);
        vertexes[2] = new Vector3(0.5f, 0.86f, 0);
        this.mesh.vertices = vertexes;

        //顶点颜色,这会影响到最终图片的显示效果
        Color32[] colors32 = new Color32[3];
        colors32[0] = new Color32(255, 0, 0, 255);
        colors32[1] = new Color32(255, 0, 0, 255);
        colors32[2] = new Color32(255, 0, 0, 255);
        this.mesh.colors32 = colors32;

        //构造三角形
        int[] triangles = new int[] { 0, 1, 2 };
        this.mesh.triangles = triangles;

        //定义法线
        Vector3[] normals = new Vector3[4];
        normals[0] = new Vector3(0, 0, -10);
        normals[1] = new Vector3(0, 0, -10);
        normals[2] = new Vector3(0, 0, -10);
        this.mesh.normals = normals;

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
}
