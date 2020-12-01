using System;
using System.Collections;
using System.Collections.Generic;
using CubeSpawner;
using UnityEngine;

public class Cube
{
    private float _speed;
    private float _lifeDistance;
    private Vector3 _position;

    public Action OnDespawn = () => { };

    public Cube(float speed, float lifeDistance)
    {
        _speed = speed;
        _lifeDistance = lifeDistance;
        _position = Vector3.zero;
    }

    public void FixedUpdate(float fixedDeltaTime)
    {
        _position += Vector3.right * _speed * fixedDeltaTime;
        if (_position.x >= _lifeDistance)
        {
            OnDespawn();
        }
    }

    public Vector3 GetPosition()
    {
        return _position;
    }
}
