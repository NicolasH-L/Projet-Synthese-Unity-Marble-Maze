using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Script
{
    public class SetVolume : MonoBehaviour
    {
        // [SerializeField] private AudioMixer mixer;
        private AudioSource _audioSong;
        private Slider _slider;

        private void Start()
        {
            _audioSong = GetComponent<AudioSource>();
            _audioSong.volume = 0.25f;
            // _slider = GetComponent<Slider>();
            // _slider.value = 0.5f;
            // mixer.SetFloat("MusicVol", Mathf.Log10(_slider.value) * 50);
        }

        public void SetLevel(float sliderValue)
        {
            // mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 50);
            _audioSong.volume = sliderValue;
        }
    }
}