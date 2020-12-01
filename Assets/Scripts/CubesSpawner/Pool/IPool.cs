using UnityEngine;

namespace CubeSpawner
{
    public interface IPool
    {
        GameObject Spawn(Vector3 position);
        void HideToPool(GameObject g);
        void Preload(int qty);
    }
}