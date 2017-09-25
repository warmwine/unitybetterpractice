using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrder
{
    public class Data
    {
        public static int executionOrder = 0;
    }

    public class Handler
    {
        public void Execute(string info)
        {
            Data.executionOrder++;
            Debug.Log(info + ":" + Data.executionOrder);
        }
    }
}

