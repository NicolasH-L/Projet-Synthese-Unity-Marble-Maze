using UnityEngine;

namespace Script
{
    public class SpinningDivider : MonoBehaviour
    {
        private const int RotationSpeed = 100;

        void Update()
        {
            transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
        }
    }
}
