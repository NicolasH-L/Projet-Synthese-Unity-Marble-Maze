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

        private void Start()
        {
            resultTime.text = TimerManager.Timer1Text() + TextSeconds;
            resultTime2.text = TimerManager.Timer2Text() + TextSeconds;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}