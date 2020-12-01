using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public interface ISpawner
    {
        void StartSpawning(IPool pool, float frequency);
        void StopSpawning();
    }

}