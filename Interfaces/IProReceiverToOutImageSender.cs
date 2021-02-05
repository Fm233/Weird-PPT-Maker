using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProReceiverToOutImageSender
{
    void AddOiiReceiver(Action<OutImageInf> action);
}
