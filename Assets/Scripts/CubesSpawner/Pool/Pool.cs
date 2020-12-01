using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public class Pool : MonoBehaviour, IPool
    {
        private const int PreloadQty = 20;

        [SerializeField] private GameObject _prefab;
        private Stack<GameObject> _inactiveObjects;

        private void Awake()
        {
            _inactiveObjects = new Stack<GameObject>(PreloadQty);
        }

        public GameObject Spawn(Vector3 position)
        {
            if (_inactiveObjects.Count > 0)
            {
                GameObject b = _inactiveObjects.Pop();
                b.transform.position = position;
                b.transform.rotation = Quaternion.identity;
                b.gameObject.SetActive(true);
                return b;
            }
            else
            {
                return Instantiate(_prefab, position, Quaternion.identity);
            }
        }


        public void HideToPool(GameObject b)
        {
            b.gameObject.SetActive(false);
            _inactiveObjects.Push(b);
        }

        public void Preload(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                GameObject newObj = Instantiate(_prefab);
                HideToPool(newObj);
            }
        }
    }
}