using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MoleGame
{
    public class UiManager : MonoBehaviour
    {
        public GameObject[] heart;
        public GameObject Game;
        public GameObject Ui;

        void Start()
        {
            MoleGameManager.instance.uiManager = this;
        }

        public void Play()
        {
            MoleGameManager.instance.audioManager.audio_Button.Play();

            Ui.SetActive(false);
            Game.SetActive(true);

            MoleGameManager.instance.moleManager.Game_Start();
        }

        public void End()
        {
            MoleGameManager.instance.audioManager.audio_End.Play();
            MoleGameManager.instance.ResetValue();

            SceneManager.LoadScene(0);
        }
    }
}

