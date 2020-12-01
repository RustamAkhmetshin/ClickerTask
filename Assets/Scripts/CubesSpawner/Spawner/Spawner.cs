using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public class Spawner : MonoBehaviour, ISpawner, ISubscriberDataChange
    {
        private float _spawnFrequency;
        private bool _isSpawning = false;

        private IPool _pool;

        private float _spawnDelay = 0;

        private void Update()
        {
            if (_isSpawning)
            {
                _spawnDelay += Time.deltaTime;

                if (_spawnDelay >= _spawnFrequency)
                {
                    _pool.Spawn(Vector3.zero);
                    _spawnDelay = 0;
                }
            }
        }

        public void StartSpawning(IPool pool, float frequency)
        {
            _pool = pool;
            _spawnFrequency = frequency;
            _isSpawning = true;
        }

        public void StopSpawning()
        {
            _isSpawning = false;
        }

        void OnEnable()
        {
            EventManager.Subscribe(this);
        }

        void OnDisable()
        {
            EventManager.Unsubscribe(this);
        }

        public void RaiseEvent(LevelData levelData)
        {
            _spawnFrequency = levelData.SpawnFrequency;
        }
    }
}