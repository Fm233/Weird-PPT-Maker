using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProReceiverToOutRegionReceiver
{
    Action<OutRegionInf> GetOriReceiver();
}
