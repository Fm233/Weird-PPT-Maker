using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInPdfToProImportReceiver
{
    Action<Pdf> GetPdfReceiver();
}
