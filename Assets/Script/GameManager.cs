using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _gameManager;
    public static GameManager GameManagerInstance => _gameManager;

    private const string WelcomeScreen = "WelcomeScreen";
    private const string WinScene1 = "WinP1Screen";
    private const string Player1 = "Marble1";
    private const string Player2 = "Marble2";

    private AudioSource _audioSource;

    public bool _isP1Screen;

    public bool _isP2Screen;
    // private float sliderValue;

    private void Awake()
    {
        if (_gameManager != null && _gameManager != this)
            Destroy(gameObject);
        else
            _gameManager = this;
    }

    void Start()
    {
        _isP1Screen = false;
        _isP2Screen = false;
        // sliderValue = 0.5f;
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
        DontDestroyOnLoad(this);
    }

    // public void Volume()
    // {
    //     sliderValue = GUI.HorizontalSlider(new Rect(25, 25, 200, 60), sliderValue, 0.0F, 1.0F);
    //     _audioSource.volume = sliderValue;
    // }

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

    public void CompleteGame(string player)
    {
        if (player == Player1)
        {
            Debug.Log("p1");
            _isP1Screen = true;
            SceneManager.LoadScene(WinScene1);
        }

        if (player == Player2)
        {
            _isP2Screen = true;
            SceneManager.LoadScene(WinScene1);
            Debug.Log("player 2");
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(WelcomeScreen);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}