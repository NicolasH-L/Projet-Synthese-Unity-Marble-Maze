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

        private void Start()
        {
            resultTime.text = TimerManager.time;
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}