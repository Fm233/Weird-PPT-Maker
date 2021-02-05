using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProReceiverToOutRegionSender
{
    void AddOriReceiver(Action<OutRegionInf> action);
}
