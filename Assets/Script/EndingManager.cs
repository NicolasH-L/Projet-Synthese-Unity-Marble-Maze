using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class EndingManager : MonoBehaviour
    {
        private const string WelcomeScreen = "WelcomeScreen";

        public void MainMenu()
        {
            SceneManager.LoadScene(WelcomeScreen);
        }
    }
}