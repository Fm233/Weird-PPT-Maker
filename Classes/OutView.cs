using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutView : MonoBehaviour, IInViewToOutViewReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<ViewInf> GetViReceiver()
    {
        return ReceiveVi;
    }
    public void ReceiveVi(ViewInf vi)
    {
        // Fill receiver function here
    }
}
