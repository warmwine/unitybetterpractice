using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CallOtherScripts
{
    public class Data
    {
        public static int global_data = 10;
    }

    public class Other_Script
    {

        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        void Start()
        {
            Debug.Log("Do nothing");
        }
    }
}