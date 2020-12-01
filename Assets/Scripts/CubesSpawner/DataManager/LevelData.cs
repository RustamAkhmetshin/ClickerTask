using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSpawner
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "LevelData")]
    public class LevelData : ScriptableObject
    {
        public float SpawnFrequency;
        public float CubeVelocity;
        public float Distance;
    }
}
