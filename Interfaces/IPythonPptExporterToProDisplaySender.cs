using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IPythonPptExporterToProDisplaySender
{
    void AddPptDirReceiver(Action<string> action);
}
