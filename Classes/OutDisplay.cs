using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutDisplay : MonoBehaviour, IProDisplayToOutDisplayReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<string> GetDirReceiver()
    {
        return ReceiveDir;
    }
    public void ReceiveDir(string dir)
    {
        // Fill receiver function here
    }
}
