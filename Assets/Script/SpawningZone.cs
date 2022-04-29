using UnityEngine;

namespace Script
{
    public class SpawningZone : MonoBehaviour
    {
        [SerializeField] private GameObject marblePrefab;
        private GameObject _currentMarble;

        private void Start()
        {
            var position = transform.position;
            _currentMarble = Instantiate(marblePrefab, new Vector3(position.x, position.y, position.z),
                Quaternion.identity);
        }

        private void Update()
        {
            if (_currentMarble != null) return;
            var position = transform.position;
            _currentMarble = Instantiate(marblePrefab, new Vector3(position.x, position.y, position.z),
                Quaternion.identity);
        }
    }
}