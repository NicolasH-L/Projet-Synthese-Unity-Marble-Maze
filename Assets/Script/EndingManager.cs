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
        [SerializeField] private TextMeshProUGUI winner;
        private TimerManager _timerManager;
        private GameManager _gameManager;

        private void Start()
        {
            _gameManager = GameManager.GameManagerInstance;
            _timerManager = GameObject.FindWithTag("TimeManager").GetComponent<TimerManager>();
            resultTime.text = _timerManager.GetTimer1().ToString("0.00") + TextSeconds;
            resultTime2.text = _timerManager.GetTimer2().ToString("0.00") + TextSeconds;
            winner.text = _gameManager.ComparePlayerTime(_timerManager.GetTimer1(), _timerManager.GetTimer2());
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}