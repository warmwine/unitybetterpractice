using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovingObject
{
    public class BasketBall : MonoBehaviour
    {
        private float speed = 0.0f;
        private float acceleration = 0.01f;
        private Vector3 currentPos = new Vector3 { };
        // Use this for initialization
        void Start()
        {
            this.currentPos = this.transform.position;
            this.currentPos.x = -10;
            this.transform.position = this.currentPos;
            this.speed = 0.0f;
            this.acceleration = 0.01f;
        }

        void FixedUpdate()
        {
            this.currentPos.x = this.currentPos.x + this.speed;
            this.transform.position = this.currentPos;
            this.speed = this.speed + this.acceleration;
            if (this.speed > 0.4f || this.speed < -0.4f)
            {
                this.acceleration = -this.acceleration;
            }
        }
    }
}
