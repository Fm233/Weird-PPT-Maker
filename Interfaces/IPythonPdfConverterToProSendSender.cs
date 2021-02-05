using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IPythonPdfConverterToProSendSender
{
    void AddPprReceiver(Action<PythonPdfReturn> action);
}
