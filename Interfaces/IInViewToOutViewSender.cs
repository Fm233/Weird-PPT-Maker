using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInViewToOutViewSender
{
    void AddViReceiver(Action<ViewInf> action);
}
