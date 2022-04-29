using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class TimerManager : MonoBehaviour
    {
        public static TimerManager TimerManagerInstance { get; private set; }

        private const int AddPenaltyTime = 5;
        private const int DeductTime = 10;
        private const string TimeFormat = "0.00";
        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private TextMeshProUGUI timerText2;
        private float _currentTime;
        private float _currentTime2;

        private void Start()
        {
            TimerManagerInstance = GetComponent<TimerManager>();
            DontDestroyOnLoad(this);
        }

        private void Update()
        {
            InitializeChronometer();
        }

        private void InitializeChronometer()
        {
            if (GameManager.GameManagerInstance.CheckTime() == false)
            {
                _currentTime = _currentTime += Time.deltaTime;
                timerText.text = _currentTime.ToString(TimeFormat);
            }

            if (GameManager.GameManagerInstance.CheckTime2()) return;
            _currentTime2 = _currentTime2 += Time.deltaTime;
            timerText2.text = _currentTime2.ToString(TimeFormat);
        }

        public float GetTimer1()
        {
            return _currentTime;
        }

        public float GetTimer2()
        {
            return _currentTime2;
        }

        public void PenaltyTimePlayer1()
        {
            _currentTime += AddPenaltyTime;
        }

        public void PenaltyTimePlayer2()
        {
            _currentTime2 += AddPenaltyTime;
        }

        public void DeductTimePlayer1()
        {
            _currentTime -= DeductTime;
        }

        public void DeductTimePlayer2()
        {
            _currentTime2 -= DeductTime;
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
            if (SceneManager.GetActiveScene().buildIndex >= 1) return;
            Destroy(gameObject);
            Destroy(this);
        }
    }
}