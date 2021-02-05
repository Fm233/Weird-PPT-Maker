using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ProImport : MonoBehaviour, IInPdfToProImportReceiver, IInRawAnswerToProImportReceiver, IProImportToPythonPdfConverterSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<Pdf> GetPdfReceiver()
    {
        return ReceivePdf;
    }
    public void ReceivePdf(Pdf pdf)
    {
        // Fill receiver function here
    }
    public Action<string> GetRawAnswerReceiver()
    {
        return ReceiveRawAnswer;
    }
    public void ReceiveRawAnswer(string rawAnswer)
    {
        // Fill receiver function here
    }
    Action<PythonPdfInf> ppiAction;
    public void AddPpiReceiver(Action<PythonPdfInf> action)
    {
        ppiAction += action;
    }
}
