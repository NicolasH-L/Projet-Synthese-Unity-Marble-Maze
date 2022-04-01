using UnityEngine;

namespace Script
{
    public class EndGame : MonoBehaviour
    {
        private const string Player1 = "Marble1";
        private const string Player2 = "Marble2";
        private GameManager _gameManager;

        private void Start()
        {
            _gameManager = GameManager.GameManagerInstance;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Player1))
                _gameManager.CompleteGame(Player1);
            else if (other.gameObject.CompareTag(Player2))
                _gameManager.CompleteGame(Player2);
        }
    }
}