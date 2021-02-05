using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IPythonPptExporterToProDisplayReceiver
{
    Action<string> GetPptDirReceiver();
}
