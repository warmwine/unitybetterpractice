﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Mesh mesh = null;
    private MeshRenderer meshRenderer = null;
    private Rigidbody2D body = null;
    public float speed = 1000.0f;

    void CreatePlayer()
    {
        this.mesh = gameObject.AddComponent<MeshFilter>().mesh;//网格对象
        this.meshRenderer = gameObject.AddComponent<MeshRenderer>();//网格渲染器
        this.meshRenderer.material = new Material(Shader.Find("Sprites/Default"));//材质

        Vector3[] vertexes = new Vector3[4];
        vertexes[0] = new Vector3(0, 0, 0);
        vertexes[1] = new Vector3(1, 0, 0);
        vertexes[2] = new Vector3(1, 1, 0);
        vertexes[3] = new Vector3(0, 1, 0);
        this.mesh.vertices = vertexes;

        Color32[] colors32 = new Color32[4];
        colors32[0] = new Color32(255, 0, 0, 255);
        colors32[1] = new Color32(255, 0, 0, 255);
        colors32[2] = new Color32(255, 0, 0, 255);
        colors32[3] = new Color32(255, 0, 0, 255);
        this.mesh.colors32 = colors32;

        int[] triangles = new int[] { 0, 2, 1, 0, 3, 2 };
        this.mesh.triangles = triangles;

        Vector3[] normals = new Vector3[4];
        normals[0] = new Vector3(0, 0, -10);
        normals[1] = new Vector3(0, 0, -10);
        normals[2] = new Vector3(0, 0, -10);
        normals[3] = new Vector3(0, 0, -10);
        this.mesh.normals = normals;
    }

    void CreateCollider()
    {
        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(1, 1);
        this.body = gameObject.AddComponent<Rigidbody2D>();
        this.body.gravityScale = 0.0f;
    }


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        this.CreatePlayer();
        this.CreateCollider();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        float angel = 0.0f;
        float moving = 1.0f;

        if (Input.GetKey(KeyCode.A))
        {
            angel = Mathf.PI;
            if (Input.GetKey(KeyCode.S))
            {
                angel = angel + Mathf.PI * 0.25f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                angel = angel - Mathf.PI * 0.25f;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            angel = 0.0f;
            if (Input.GetKey(KeyCode.S))
            {
                angel = Mathf.PI * 1.75f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                angel = Mathf.PI * 0.25f;
            }
        }
        else
        {
            angel = 0.0f;
            if (Input.GetKey(KeyCode.S))
            {
                angel = Mathf.PI * 1.5f;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                angel = Mathf.PI * 0.5f;
            }
            else
            {
                moving = 0.0f;
            }
        }

        float cx = this.speed * Mathf.Cos(angel) * moving;
        float cy = this.speed * Mathf.Sin(angel) * moving;
        print(cx);
        print(cy);
        this.body.velocity = new Vector2(cx, cy);
    }
}

