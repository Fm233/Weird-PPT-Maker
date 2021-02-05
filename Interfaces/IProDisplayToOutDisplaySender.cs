using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProDisplayToOutDisplaySender
{
    void AddDirReceiver(Action<string> action);
}
