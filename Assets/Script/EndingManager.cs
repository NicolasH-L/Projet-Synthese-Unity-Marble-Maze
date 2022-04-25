using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class EndingManager : MonoBehaviour
    {
        private const string WelcomeScreen = "WelcomeScreen";
        private const string TextSeconds = " seconds";
        [SerializeField] private TextMeshProUGUI resultTime;
        [SerializeField] private TextMeshProUGUI resultTime2;
        private TimerManager _timerManager;

        private void Start()
        {
            _timerManager = GameObject.FindWithTag("TimeManager").GetComponent<TimerManager>();
            resultTime.text = _timerManager.Timer1Text() + TextSeconds;
            resultTime2.text = _timerManager.Timer2Text() + TextSeconds;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}