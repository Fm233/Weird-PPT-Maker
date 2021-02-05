using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ProDisplay : MonoBehaviour, IPythonPptExporterToProDisplayReceiver, IProDisplayToOutDisplaySender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<string> GetPptDirReceiver()
    {
        return ReceivePptDir;
    }
    public void ReceivePptDir(string pptDir)
    {
        // Fill receiver function here
    }
    Action<string> dirAction;
    public void AddDirReceiver(Action<string> action)
    {
        dirAction += action;
    }
}
