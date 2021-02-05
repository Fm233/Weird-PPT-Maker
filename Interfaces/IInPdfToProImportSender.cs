using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInPdfToProImportSender
{
    void AddPdfReceiver(Action<Pdf> action);
}
