using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public interface ISubscriberDespawner
    {
        void RaiseEvent();
    }
}