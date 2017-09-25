using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Just_Run_It : MonoBehaviour
{
    protected int updatedTimes = 0;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        Debug.Log("Application start, entrance awaked");
    }

    /// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
    {
        Debug.Log("Application start, entrance started");
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        this.updatedTimes++;
        Debug.Log("Application start, entrance updated " + this.updatedTimes + " times");
    }
}
