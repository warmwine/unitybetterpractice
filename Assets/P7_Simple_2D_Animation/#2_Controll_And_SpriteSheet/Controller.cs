using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction
{
    None,
    Up,
    Down,
    Left,
    Right,
}

public class Controller : MonoBehaviour
{

    Direction direction = Direction.Down;
    Direction walking = Direction.None;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (this.walking != Direction.Left)
            {
                this.direction = Direction.Left;
                this.walking = Direction.Left;
                Animator anim = this.GetComponent<Animator>();
                anim.Play("walk_left");
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (this.walking != Direction.Right)
            {
                this.direction = Direction.Right;
                this.walking = Direction.Right;
                Animator anim = this.GetComponent<Animator>();
                anim.Play("walk_right");
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (this.walking != Direction.Down)
            {
                this.direction = Direction.Down;
                this.walking = Direction.Down;
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (this.walking != Direction.Up)
            {
                this.direction = Direction.Up;
                this.walking = Direction.Up;
            }
        }
        else
        {

        }
    }
}
