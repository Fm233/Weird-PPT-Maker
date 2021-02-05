using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ProExport : MonoBehaviour, IProReceiverToProExportReceiver, IProExportToPythonPptExporterSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<ProExportInf> GetPeiReceiver()
    {
        return ReceivePei;
    }
    public void ReceivePei(ProExportInf pei)
    {
        // Fill receiver function here
    }
    Action<PythonPptInf> ppiAction;
    public void AddPpiReceiver(Action<PythonPptInf> action)
    {
        ppiAction += action;
    }
}
