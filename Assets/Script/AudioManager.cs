using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleGame
{
    public class AudioManager : MonoBehaviour
    {
        public AudioSource audio_Button;
        public AudioSource audio_Hit;
        public AudioSource audio_End;

        void Start()
        {
            MoleGameManager.instance.audioManager = this;
        }
    }
}

