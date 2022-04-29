using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class EndingManager : MonoBehaviour
    {
        private const string WelcomeScreen = "WelcomeScreen";
        private const string TextSeconds = " seconds";
        private const string TimeFormat = "0.00";
        [SerializeField] private TextMeshProUGUI resultTime;
        [SerializeField] private TextMeshProUGUI resultTime2;
        [SerializeField] private TextMeshProUGUI winner;
        private TimerManager _timerManager;
        private GameManager _gameManager;

        private void Start()
        {
            _gameManager = GameManager.GameManagerInstance;
            _timerManager = TimerManager.TimerManagerInstance;
            resultTime.text = _timerManager.GetPlayer1Time().ToString(TimeFormat) + TextSeconds;
            resultTime2.text = _timerManager.GetPlayer2Time().ToString(TimeFormat) + TextSeconds;
            winner.text =
                _gameManager.ComparePlayerTime(_timerManager.GetPlayer1Time(), _timerManager.GetPlayer2Time());
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}