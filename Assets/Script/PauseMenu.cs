using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class PauseMenu : MonoBehaviour
    {
        private const string WelcomeScreen = "WelcomeScreen";
        private const string GameManager = "GameManager";
        private const string TimeManager = "TimeManager";
        [SerializeField] private GameObject pauseMenuUI;
        private bool _gameIsPaused;

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Escape)) return;
            if (_gameIsPaused)
                Resume();
            else
                Pause();
        }

        public void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            _gameIsPaused = false;
        }

        public void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            _gameIsPaused = true;
        }

        public void LoadMenu()
        {
            Time.timeScale = 1f;
            Destroy(GameObject.FindWithTag(GameManager));
            Destroy(GameObject.FindWithTag(TimeManager));
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}