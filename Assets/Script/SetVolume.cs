using UnityEngine;

namespace Script
{
    public class SetVolume : MonoBehaviour
    {
        private const float VolumeValue = 0.20f;
        private AudioSource _audioSong;

        private void Start()
        {
            _audioSong = GetComponent<AudioSource>();
            _audioSong.volume = VolumeValue;
        }

        public void SetLevel(float sliderValue)
        {
            _audioSong.volume = sliderValue;
        }
    }
}