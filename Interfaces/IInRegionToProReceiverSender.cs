using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInRegionToProReceiverSender
{
    void AddIriReceiver(Action<InRegionInf> action);
}
