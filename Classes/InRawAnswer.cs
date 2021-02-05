using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InRawAnswer : MonoBehaviour, IInRawAnswerToProImportSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    Action<string> rawAnswerAction;
    public void AddRawAnswerReceiver(Action<string> action)
    {
        rawAnswerAction += action;
    }
}
