using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ProSend : MonoBehaviour, IPythonPdfConverterToProSendReceiver, IProSendToProReceiverSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<PythonPdfReturn> GetPprReceiver()
    {
        return ReceivePpr;
    }
    public void ReceivePpr(PythonPdfReturn ppr)
    {
        // Fill receiver function here
    }
    Action<ProInf> piAction;
    public void AddPiReceiver(Action<ProInf> action)
    {
        piAction += action;
    }
}
