using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProReceiverToProExportSender
{
    void AddPeiReceiver(Action<ProExportInf> action);
}
