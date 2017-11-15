using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction
{
    None = 0,
    Up = 2,
    Down = 1,
    Left = 3,
    Right = 4,
}

public class Controller : MonoBehaviour
{
    float speed = 0.1f;

    Animator anim = null;

    // Use this for initialization
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        this.anim = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        int lr = 0;
        int ud = 0;
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.S))
            {
                lr = 0;
                ud = -1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                lr = 0;
                ud = 1;
            }
            else
            {
                lr = -1;
                ud = 0;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.S))
            {
                lr = 0;
                ud = -1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                lr = 0;
                ud = 1;
            }
            else
            {
                lr = 1;
                ud = 0;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                lr = 0;
                ud = -1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                lr = 0;
                ud = 1;
            }
            else
            {
                lr = 0;
                ud = 0;
            }
        }

        anim.SetInteger("VLeftRight", lr);
        anim.SetInteger("VUpDown", ud);

        float cx = this.speed * lr;
        float cy = this.speed * ud;
        Vector3 pos = transform.position;
        pos.x += cx;
        pos.y += cy;
        transform.position = pos;
    }
}
