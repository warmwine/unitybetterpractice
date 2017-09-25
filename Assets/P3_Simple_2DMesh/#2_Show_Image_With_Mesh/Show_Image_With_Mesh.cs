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
        this.meshRenderer.material = new Material(Shader.Find("Sprites/Default"));//材质
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

        //顶点颜色,这会影响到最终图片的显示效果
        Color32[] colors32 = new Color32[4];
        colors32[0] = new Color32(0, 0, 0, 0);
        colors32[1] = new Color32(255, 255, 0, 255);
        colors32[2] = new Color32(255, 0, 0, 255);
        colors32[3] = new Color32(255, 255, 0, 255);
        this.mesh.colors32 = colors32;

        //矩形是由2个三角形组成的。
        //注意坐标系的左手螺旋定律来决定三角形的正面朝向是正z轴还是负z轴。
        //如果是背面朝向摄影机，该三角形是不会被渲染的。
        int[] triangles = new int[] { 0, 2, 1, 0, 3, 2 };
        this.mesh.triangles = triangles;

        //以上使用螺旋定律来解决的问题，
        //还可以通过指定法线来解决。
        //每个顶点的法线
        Vector3[] normals = new Vector3[4];
        normals[0] = new Vector3(0, 0, -10);
        normals[1] = new Vector3(0, 0, -10);
        normals[2] = new Vector3(0, 0, -10);
        normals[3] = new Vector3(0, 0, -10);
        this.mesh.normals = normals;

    }

    void SetTextureAsTheMaterial()
    {
        //通过改变默认的Sprite/Default材质的主要纹理图片来替换渲染内容
        meshRenderer.material.mainTexture = this.texture;

        //UV贴图坐标，没有UV坐标，渲染器无法得知如何渲染纹理
        Vector2[] uvs = new Vector2[4];
        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(1, 1);
        uvs[3] = new Vector2(0, 1);
        this.mesh.uv = uvs;
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

        //创建完毕矩形以后，需要额外设置纹理UV图片
        this.SetTextureAsTheMaterial();
    }
}
