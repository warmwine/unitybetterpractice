using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caller : MonoBehaviour
{

    /// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
    {
        Debug.Log("The value of data in other script is " + CallOtherScripts.Data.global_data);
    }
}
