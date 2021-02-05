using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class PythonPptExporter : MonoBehaviour, IProExportToPythonPptExporterReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<PythonPptInf> GetPpiReceiver()
    {
        return ReceivePpi;
    }
    public void ReceivePpi(PythonPptInf ppi)
    {
        // Fill receiver function here
    }
}
