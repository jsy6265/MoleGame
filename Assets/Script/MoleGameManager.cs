using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleGame
{
    public class MoleGameManager : MonoBehaviour
    {
        public static MoleGameManager instance = null;

        void Awake()
        {
            if (null == instance)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public MoleManager moleManager;
        public UiManager uiManager;
        public AudioManager audioManager;

        public int global_Heart;
        public int score;
        public bool isEnd;

        private void Start()
        {
            
        }

        public void ResetValue()
        {
            global_Heart = 0;
            score = 0;
            isEnd = false;
        }

        
    }
}

