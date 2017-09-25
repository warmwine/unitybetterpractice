using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovingObject
{
    public class CodeGravity : MonoBehaviour
    {
        private float speed = 0.0f;
        private float acceleration = -0.0098f;
        private Vector3 currentPos = new Vector3 { };
        // Use this for initialization
        void Start()
        {
            this.currentPos = this.transform.position;
            this.speed = 0.0f;
            this.acceleration = -0.0098f;
        }

        void FixedUpdate()
        {
            this.speed = this.speed + this.acceleration;
            this.currentPos.y = this.currentPos.y + this.speed;
            this.transform.position = this.currentPos;
            if (this.currentPos.y < -4)
            {
                this.speed = 0.4f;
            }
        }
    }
}