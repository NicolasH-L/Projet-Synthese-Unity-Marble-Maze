using System;
using UnityEngine;

namespace Script
{
    public class SpawningZone : MonoBehaviour
    {
        [SerializeField] private GameObject marblePrefab;
        private GameObject _currentMarble;

        private void Start()
        {
            _currentMarble = Instantiate(marblePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
        }

        void Update()
        {
            if (_currentMarble == null)
            { 
                _currentMarble = Instantiate(marblePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                    Quaternion.identity);
            }
        }
    }
}