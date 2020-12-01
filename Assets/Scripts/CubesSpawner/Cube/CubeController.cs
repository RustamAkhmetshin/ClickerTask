using System.Collections;
using System.Collections.Generic;
using CubeSpawner;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    private Cube _cube;
    
    
    private void Start()
    {
        _cube.OnDespawn += OnDespawn;
    }

    private void OnEnable()
    {
        _cube = new Cube(_levelData.CubeVelocity, _levelData.Distance);
    }

    
    private void FixedUpdate()
    {
        _cube.FixedUpdate(Time.fixedDeltaTime);
        transform.position = _cube.GetPosition();
    }

    public void OnDespawn()
    {
        Root.Instance.Pool.HideToPool(gameObject);
    }
}
