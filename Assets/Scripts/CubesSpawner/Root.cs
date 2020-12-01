using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public class Root : MonoBehaviour
    {
        public static Root Instance;
        
        private ILevelDataManager _dataManager;
        public IPool Pool;
        private ISpawner _spawner;

        private void Awake()
        {
            Instance = this;
            _dataManager = GetComponent<LevelDataManager>();
            Pool = GetComponent<Pool>();
            _spawner = GetComponent<Spawner>();
        }

        private void Start()
        {
            _spawner.StartSpawning(Pool, _dataManager.GetLevelData().SpawnFrequency);
        }
    }
}
