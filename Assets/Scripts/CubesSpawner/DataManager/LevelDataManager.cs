using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubeSpawner
{
    public class LevelDataManager : MonoBehaviour, ILevelDataManager
    {
        [SerializeField] private InputField _spawnFrequencyField;
        [SerializeField] private InputField _cubeVelocityField;
        [SerializeField] private InputField _distanceField;

        [SerializeField] private LevelData _levelData;

        private void Start()
        {
            _spawnFrequencyField.text = _levelData.SpawnFrequency.ToString();
            _cubeVelocityField.text = _levelData.CubeVelocity.ToString();
            _distanceField.text = _levelData.Distance.ToString();
            
            _spawnFrequencyField.onEndEdit.AddListener((s) =>
            {
                if (s != "")
                {
                    _levelData.SpawnFrequency = float.Parse(s);
                    EventManager.RaiseEvent(_levelData);
                }
            });
        
            _cubeVelocityField.onEndEdit.AddListener((s) =>
            {
                if (s != "")
                {
                    _levelData.CubeVelocity = float.Parse(s);
                    EventManager.RaiseEvent(_levelData);
                }
            });
        
            _distanceField.onEndEdit.AddListener((s) =>
            {
                if (s != "")
                {
                    _levelData.Distance = float.Parse(s);
                    EventManager.RaiseEvent(_levelData);
                }
            });
        }


        public LevelData GetLevelData()
        {
            return _levelData;
        }
    }
}

