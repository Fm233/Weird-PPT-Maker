using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProExportToPythonPptExporterSender
{
    void AddPpiReceiver(Action<PythonPptInf> action);
}
