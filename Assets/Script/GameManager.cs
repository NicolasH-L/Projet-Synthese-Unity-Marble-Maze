using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance { get; private set; }

    private const string WinScene = "WinningScreen";
    private const string Player1Win = "Player 1 win!";
    private const string Player2Win = "Player 2 win!";
    private const string Player1 = "Marble1";
    private const string Player2 = "Marble2";
    private bool _player1Finished;
    private bool _player2Finished;
    private bool _isTimer1Done;
    private bool _isTimer2Done;
    private string _displayWinner;

    private void Awake()
    {
        if (GameManagerInstance != null && GameManagerInstance != this)
            Destroy(gameObject);
        else
            GameManagerInstance = this;
    }

    private void Start()
    {
        _player1Finished = false;
        _player2Finished = false;
        _isTimer1Done = false;
        _isTimer2Done = false;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (_player1Finished && _player2Finished)
            SceneManager.LoadScene(WinScene);
        CheckStatus();
    }

    private void CheckStatus()
    {
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
        switch (player)
        {
            case Player1:
                _player1Finished = true;
                break;
            case Player2:
                _player2Finished = true;
                break;
        }
    }

    public string ComparePlayerTime(float timePlayer1, float timePlayer2)
    {
        _displayWinner = timePlayer1 < timePlayer2 ? Player1Win : Player2Win;
        return _displayWinner;
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