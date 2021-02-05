using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public interface IInRawAnswerToProImportSender
{
    void AddRawAnswerReceiver(Action<string> action);
}
