using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class PythonPdfConverter : MonoBehaviour, IProImportToPythonPdfConverterReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<PythonPdfInf> GetPpiReceiver()
    {
        return ReceivePpi;
    }
    public void ReceivePpi(PythonPdfInf ppi)
    {
        // Fill receiver function here
    }
}
