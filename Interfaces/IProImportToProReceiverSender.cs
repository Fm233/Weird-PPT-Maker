using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProImportToProReceiverSender
{
    void AddPiReceiver(Action<ProInf> action);
}
