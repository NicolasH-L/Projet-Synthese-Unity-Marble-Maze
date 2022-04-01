using UnityEngine;

namespace Script
{
    public class BaseScript : MonoBehaviour
    {
        private const float Smooth = 5.0f;
        private const float TiltAngle = 6.0f;

        void Update()
        {
            float tiltAxeZ = Input.GetAxis("Horizontal") * TiltAngle;
            float tiltAxeX = Input.GetAxis("Vertical") * TiltAngle;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(tiltAxeX, 0, -tiltAxeZ),
                Time.deltaTime * Smooth);
        }
    }
}