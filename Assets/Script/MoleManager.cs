using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleGame
{
    public class MoleManager : MonoBehaviour
    {
        public GameObject[] mole;
        public GameObject[] blackmole; 

        void Start()
        {
            MoleGameManager.instance.moleManager = this;
        }
        public void Game_Start()
        {
            StartCoroutine(GameStart());
        }

        IEnumerator GameStart()
        {
            while (MoleGameManager.instance.isEnd == false)
            {
                int arr = Random.Range(1, 50);
                int mole_sp = Random.Range(0, 9);
                if (MoleGameManager.instance.global_Heart >= 4)
                {
                    MoleGameManager.instance.isEnd = true;
                    MoleGameManager.instance.uiManager.End();
                    break;
                    
                }
                else if (arr % 3 != 0 && mole[mole_sp].activeSelf == false && blackmole[mole_sp].activeSelf == false)
                {
                    mole[mole_sp].SetActive(true);
                    yield return new WaitForSeconds(0.8f);
                    if (mole[mole_sp].activeSelf == true)
                    {
                        mole[mole_sp].SetActive(false);
                    }
                    yield return new WaitForSeconds(1.5f);
                }
                else if (arr % 3 == 0 && mole[mole_sp].activeSelf == false && blackmole[mole_sp].activeSelf == false)
                {
                    blackmole[mole_sp].SetActive(true);
                    yield return new WaitForSeconds(0.8f);
                    if (blackmole[mole_sp].activeSelf == true)
                    {
                        blackmole[mole_sp].SetActive(false);

                    }
                    yield return new WaitForSeconds(1.5f);
                }
                else
                {
                    continue;
                }
            }

        }

    }
}

