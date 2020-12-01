using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    
    public interface ISubscriberDataChange
    {
        void RaiseEvent(LevelData levelData);
    }
}

