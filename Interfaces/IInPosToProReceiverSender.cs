using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInPosToProReceiverSender
{
    void AddIpiReceiver(Action<InPosInf> action);
}
