using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class InRawAnswer : MonoBehaviour, IInRawAnswerToProImportSender
{
    public InputField input;

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

    public void SendAnswer()
    {
        rawAnswerAction(input.text);
    }
}
