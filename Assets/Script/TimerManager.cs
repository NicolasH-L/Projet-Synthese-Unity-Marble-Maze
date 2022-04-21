using System;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class TimerManager : MonoBehaviour
    {
        private static TimerManager _timerManager;
        public static TimerManager TimerManagerInstance => _timerManager;

        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private TextMeshProUGUI timerText2;
        private float _currentTime;
        private float _currentTime2;
        public static string Time1;
        public static string Time2;

        private void Start()
        {
            DontDestroyOnLoad(this);
        }

        void Update()
        {
            if (GameManager.GameManagerInstance.CheckTime() == false)
            {
                _currentTime = _currentTime += Time.deltaTime;
                timerText.text = _currentTime.ToString("0.00");
            }

            if (GameManager.GameManagerInstance.CheckTime2() == false)
            {
                _currentTime2 = _currentTime2 += Time.deltaTime;
                timerText2.text = _currentTime2.ToString("0.00");
            }

            Time1 = timerText.text;
            Time2 = timerText2.text;
        }

        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            if (SceneManager.GetActiveScene().buildIndex <= 1) return;
            Destroy(gameObject);
            Destroy(this);
        }
    }
}