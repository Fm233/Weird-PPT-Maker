using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutRegion : MonoBehaviour, IProReceiverToOutRegionReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<OutRegionInf> GetOriReceiver()
    {
        return ReceiveOri;
    }
    public void ReceiveOri(OutRegionInf ori)
    {
        // Fill receiver function here
    }
}
