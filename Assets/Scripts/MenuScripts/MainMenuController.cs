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

    public GameObject SoundManager;
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenu.SetActive(false);
        SoundManager = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup < 10)
        {
            // first game opening
            // ask here for players language pref.
        }
        else
        {
            // Welcome again
        }
        // If settingmenu is active.
        if (SettingsMenu.activeInHierarchy == true)
        {
            // If user presses back button on android Settings menu closes.
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SettingsMenu.SetActive(false);
                MainMenu.SetActive(true);
            }
        }
        if (MainMenu.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
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

    public void CreditsButton(){
        Destroy(SoundManager);                                                                                                
        SceneManager.LoadScene("Credits");
    }


}

