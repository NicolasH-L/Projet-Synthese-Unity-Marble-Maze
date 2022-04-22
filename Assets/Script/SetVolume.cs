using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Script
{
    public class SetVolume : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixer;
        // private float sliderValue;
        //
        // private void Start()
        // {
        //     sliderValue = 0.5f;
        // }

        public void SetLevel(float sliderValue)
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 50);
        }
    }
}