using UnityEngine;

namespace Script
{
    public class BaseScript : MonoBehaviour
    {
        private const float Smooth = 5.0f;
        private const float TiltAngle = 5.0f;
        
        void Update()
        {
            float tiltAxeZ = Input.GetAxis("Horizontal") * TiltAngle;
            float tiltAxeX = Input.GetAxis("Vertical") * TiltAngle;
            
            Quaternion target = Quaternion.Euler(tiltAxeX, 0, tiltAxeZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * Smooth);
        }
    }
}
