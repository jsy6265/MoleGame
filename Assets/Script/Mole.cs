using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoleGame
{
    public class Mole : MonoBehaviour
    {
        public GameObject my_mole;

        public Image my_Img;

        public Sprite my_live;
        public Sprite my_die;

        public void MoleDes()
        {
            var Gm = MoleGameManager.instance;

            if (my_mole.activeSelf == true)
            {
                my_Img.sprite = my_die;
                if(gameObject.tag == "Mole")
                {
                    MoleGameManager.instance.audioManager.audio_Hit.Play();
                    Gm.score += 15;
                }
                else if(gameObject.tag == "Boom")
                {
                    MoleGameManager.instance.audioManager.audio_Hit.Play();
                    Gm.uiManager.heart[Gm.global_Heart].SetActive(false);
                    Gm.global_Heart += 1;
                    Gm.uiManager.heart[Gm.global_Heart].SetActive(true);

                }
                Invoke("DieOff", 0.5f);
            }
        }

        public void DieOff()
        {
            my_Img.sprite = my_live;
            my_mole.SetActive(false);
        }
    }
}

