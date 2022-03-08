using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;



    public class MainMenuController : MonoBehaviour
    {
        
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private GameObject MainMenu;

        [SerializeField] private GameObject AudioMusicSource;
        // Start is called before the first frame update
        void Start()
        {
            SettingsMenu.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            // If settingmenu is active.
            if(SettingsMenu.activeInHierarchy == true)
            {
                // If user presses back button on android Settings menu closes.
                if(Input.GetKeyDown(KeyCode.Escape))
                {
                    SettingsMenu.SetActive(false);
                    MainMenu.SetActive(true);
                }
            }
            if(MainMenu.activeInHierarchy == true)
            {
                 if(Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }
        }

        public void PlayButton()
        {
            
            SceneManager.LoadScene("Museum");
        }

        public void SettingsButton()
        {
            //Activate settingsmenu canvas.
            SettingsMenu.SetActive(true);
            MainMenu.SetActive(false);
        }

        public void CloseSettingsButton()
        {
            SettingsMenu.SetActive(false);
            MainMenu.SetActive(true);
            
        }

        public void Mute()
        {
            // Need to change AudioListener to AudioMixer once we have sounds etc.
            // If audio is higher than 0 then mute listener.
            if(AudioListener.volume > 0)
            {
                AudioListener.volume = 0;
            }
            if(AudioListener.volume < 0)
            {
                AudioListener.volume = 1;
            }
            
        }

        public void MuteSFX(){
            if(AudioMusicSource.activeInHierarchy == true){
           AudioMusicSource.SetActive(false);
            }
            if(AudioMusicSource.activeInHierarchy == false){
           AudioMusicSource.SetActive(true);
            }
        }
    }

