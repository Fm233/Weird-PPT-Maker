using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutPos : MonoBehaviour, IProReceiverToOutPosReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<OutPosInf> GetOpiReceiver()
    {
        return ReceiveOpi;
    }
    public void ReceiveOpi(OutPosInf opi)
    {
        // Fill receiver function here
    }
}
