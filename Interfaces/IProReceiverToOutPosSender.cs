using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProReceiverToOutPosSender
{
    void AddOpiReceiver(Action<OutPosInf> action);
}
