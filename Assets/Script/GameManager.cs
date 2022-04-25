using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _gameManager;
    public static GameManager GameManagerInstance => _gameManager;

    private const string WinScene = "WinScreen";
    private const string Player1 = "Marble1";
    private const string Player2 = "Marble2";
    private bool _player1Finished;
    private bool _player2Finished;
    private bool _isTimer1Done;
    private bool _isTimer2Done;

    private void Awake()
    {
        if (_gameManager != null && _gameManager != this)
            Destroy(gameObject);
        else
            _gameManager = this;
    }

    private void Start()
    {
        _player1Finished = false;
        _player2Finished = false;
        _isTimer1Done = false;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (_player1Finished && _player2Finished)
            SceneManager.LoadScene(WinScene);

        if (_player1Finished)
            _isTimer1Done = true;
        if (_player2Finished)
            _isTimer2Done = true;
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
        if (SceneManager.GetActiveScene().buildIndex <= 1) return;
        Destroy(gameObject);
        Destroy(this);
    }

    public void CompleteGame(string player)
    {
        if (player == Player1)
            _player1Finished = true;

        if (player == Player2)
            _player2Finished = true;
    }

    public bool CheckTime()
    {
        return _isTimer1Done;
    }

    public bool CheckTime2()
    {
        return _isTimer2Done;
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