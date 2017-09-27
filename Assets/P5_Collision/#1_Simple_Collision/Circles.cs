using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circles : MonoBehaviour
{
    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        //碰到了，带有rigidbody2d的对象绑定的脚本执行OnCollisionEnter2D
        Debug.Log(this);
        Destroy(this.GetComponent<Rigidbody2D>());
    }

}
