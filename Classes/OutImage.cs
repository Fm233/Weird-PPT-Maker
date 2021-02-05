using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class OutImage : MonoBehaviour, IProReceiverToOutImageReceiver
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    public Action<OutImageInf> GetOiiReceiver()
    {
        return ReceiveOii;
    }
    public void ReceiveOii(OutImageInf oii)
    {
        // Fill receiver function here
    }
}
