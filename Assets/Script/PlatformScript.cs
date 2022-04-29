using UnityEngine;

namespace Script
{
    public class PlatformScript : MonoBehaviour
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private const string Horizontal2 = "Horizontal2";
        private const string Vertical2 = "Vertical2";
        private const string Platform = "Platform";
        private const string Platform2 = "Platform2";
        private const float Smoothness = 5.0f;
        private const float TiltAngle = 5.0f;
        private float _tiltAxeZ;
        private float _tiltAxeX;
        private string _platformName;

        private void Start()
        {
            _platformName = transform.tag;
        }

        private void Update()
        {
            CheckPlatformControls();
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_tiltAxeX, 0, -_tiltAxeZ),
                Time.deltaTime * Smoothness);
        }

        private void CheckPlatformControls()
        {
            switch (_platformName)
            {
                case Platform:
                    _tiltAxeZ = Input.GetAxis(Horizontal) * TiltAngle;
                    _tiltAxeX = Input.GetAxis(Vertical) * TiltAngle;
                    break;
                case Platform2:
                    _tiltAxeZ = Input.GetAxis(Horizontal2) * TiltAngle;
                    _tiltAxeX = Input.GetAxis(Vertical2) * TiltAngle;
                    break;
            }
        }
    }
}