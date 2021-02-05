using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InRegion : MonoBehaviour, IInRegionToProReceiverSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    Action<InRegionInf> iriAction;
    public void AddIriReceiver(Action<InRegionInf> action)
    {
        iriAction += action;
    }
}
