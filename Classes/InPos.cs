using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InPos : MonoBehaviour, IInPosToProReceiverSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    Action<InPosInf> ipiAction;
    public void AddIpiReceiver(Action<InPosInf> action)
    {
        ipiAction += action;
    }
}
