using UnityEngine;

namespace Script
{
    public class MarbleScript : MonoBehaviour
    {
        private const string HoleTag = "Hole";
        private const string CapsuleTag = "Capsule";
        private const string Marble1Tag = "Marble1";
        private const string Marble2Tag = "Marble2";
        private TimerManager _timerManager;
        private string _marbleTag;

        private void Start()
        {
            _marbleTag = transform.tag;
            _timerManager = TimerManager.TimerManagerInstance;
        }

        private void OnTriggerEnter(Collider other)
        {
            IsMarbleTouchingHole(other);
            IsMarbleTouchingCapsule(other);
        }

        private void IsMarbleTouchingHole(Component other)
        {
            if (other.gameObject.CompareTag(HoleTag) && _marbleTag.Equals(Marble1Tag))
            {
                _timerManager.PenaltyTimePlayer1();
                Destroy(gameObject);
            }
            else if (other.gameObject.CompareTag(HoleTag) && _marbleTag.Equals(Marble2Tag))
            {
                _timerManager.PenaltyTimePlayer2();
                Destroy(gameObject);
            }
        }

        private void IsMarbleTouchingCapsule(Component other)
        {
            if (other.gameObject.CompareTag(CapsuleTag) && _marbleTag.Equals(Marble1Tag))
                _timerManager.DeductTimePlayer1();
            else if (other.gameObject.CompareTag(CapsuleTag) && _marbleTag.Equals(Marble2Tag))
                _timerManager.DeductTimePlayer2();
        }
    }
}