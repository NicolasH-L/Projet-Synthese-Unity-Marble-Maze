using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class EndingManager : MonoBehaviour
    {
        private const string WelcomeScreen = "WelcomeScreen";
        [SerializeField] private TextMeshProUGUI resultTime;
        [SerializeField] private TextMeshProUGUI resultTime2;

        private void Start()
        {
            resultTime.text = TimerManager.Time1;
            resultTime2.text = TimerManager.Time2;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}