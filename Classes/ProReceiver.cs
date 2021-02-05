using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ProReceiver : MonoBehaviour, IInPosToProReceiverReceiver, IInRegionToProReceiverReceiver, IProReceiverToOutPosSender, IProReceiverToOutRegionSender, IProReceiverToOutImageSender, IProReceiverToProExportSender, IProSendToProReceiverReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<InPosInf> GetIpiReceiver()
    {
        return ReceiveIpi;
    }
    public void ReceiveIpi(InPosInf ipi)
    {
        // Fill receiver function here
    }
    public Action<InRegionInf> GetIriReceiver()
    {
        return ReceiveIri;
    }
    public void ReceiveIri(InRegionInf iri)
    {
        // Fill receiver function here
    }
    Action<OutPosInf> opiAction;
    public void AddOpiReceiver(Action<OutPosInf> action)
    {
        opiAction += action;
    }
    Action<OutRegionInf> oriAction;
    public void AddOriReceiver(Action<OutRegionInf> action)
    {
        oriAction += action;
    }
    Action<OutImageInf> oiiAction;
    public void AddOiiReceiver(Action<OutImageInf> action)
    {
        oiiAction += action;
    }
    Action<ProExportInf> peiAction;
    public void AddPeiReceiver(Action<ProExportInf> action)
    {
        peiAction += action;
    }
    public Action<ProInf> GetPiReceiver()
    {
        return ReceivePi;
    }
    public void ReceivePi(ProInf pi)
    {
        // Fill receiver function here
    }
}
