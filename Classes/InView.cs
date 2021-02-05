using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class InView : MonoBehaviour, IInViewToOutViewSender
{
    void Start()
    {
        // Start here
    }
    void Update()
    {
        // Update here
    }
    Action<ViewInf> viAction;
    public void AddViReceiver(Action<ViewInf> action)
    {
        viAction += action;
    }
}
