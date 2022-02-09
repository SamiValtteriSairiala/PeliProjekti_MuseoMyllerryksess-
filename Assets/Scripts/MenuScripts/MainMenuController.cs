using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



    public class MainMenuController : MonoBehaviour
    {
        
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private GameObject MainMenu;
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
            // Change SampleScene to our main play scene!
            SceneManager.LoadScene("SampleScene");
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
    }

