using UnityEngine;

namespace Script
{
    public class TimeCapsule : MonoBehaviour
    {
        private const string MarbleTag1 = "Marble1";
        private const string MarbleTag2 = "Marble2";
        private const int RotationSpeed = 90;

        private void Update()
        {
            transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(MarbleTag1) || other.gameObject.CompareTag(MarbleTag2))
                Destroy(gameObject);
        }
    }
}