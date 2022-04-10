using TMPro;
using UnityEngine;

namespace Script
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private TextMeshProUGUI timerText2;
        private float _currentTime;
        private float _currentTime2;

        void Update()
        {
            _currentTime = _currentTime += Time.deltaTime;
            _currentTime2 = _currentTime2 += Time.deltaTime;
            timerText.text = _currentTime.ToString("0.00");
            timerText2.text = _currentTime2.ToString("0.00");
        }
    }
}