using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class PauseMenu : MonoBehaviour
    {
        private const string GameManagerName = "Game Manager";
        private const string WelcomeScreen = "WelcomeScreen";
        [SerializeField] private GameObject pauseMenuUI;
        private bool _gameIsPaused = false;

        void Update()
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
            // Destroy(GameObject.Find(GameManagerName));
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}