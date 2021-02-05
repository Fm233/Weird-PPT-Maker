using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IProImportToPythonPdfConverterSender
{
    void AddPpiReceiver(Action<PythonPdfInf> action);
}
