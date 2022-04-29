using UnityEngine;

namespace Script
{
    public class FinishLineScript : MonoBehaviour
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
            _gameManager.CompleteGame(other.gameObject.CompareTag(Player1) ? Player1 : Player2);
        }
    }
}