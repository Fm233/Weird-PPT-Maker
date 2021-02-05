using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProSendToProReceiverSender
{
    void AddPiReceiver(Action<ProInf> action);
}
