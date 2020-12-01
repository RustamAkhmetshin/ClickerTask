using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubscriber
{
    void RaiseEvent(string text);
}
