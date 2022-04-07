using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuCanvas;
    private GameObject GameManager;
    private Timer TimerScript;
    private GameObject AudioManager;
    private SoundManager m_SoundManager;
    [SerializeField]private Toggle MusicToggle;
    [SerializeField]private Toggle SFXToggle;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        TimerScript = GameManager.GetComponent<Timer>();
    }

    void Awake(){
       AudioManager = GameObject.Find("SoundManager");
       m_SoundManager = AudioManager.GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenuCanvas.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePauseMenu();
        }

        if(m_SoundManager.MusicIsMuted == true){
            MusicToggle.isOn = false;
        }
        else{
            MusicToggle.isOn = true;
        }
        if(m_SoundManager.SFXisMuted == true){
            SFXToggle.isOn = false;
        }
        else{
            SFXToggle.isOn = true;
        }
        
    }

    public void OpenPauseMenu()
    {
        PauseMenuCanvas.SetActive(true);
        if (TimerScript.TimerHasStarted == true)
        {
            TimerScript.TimerPaused = true;
        }

    }

    public void ClosePauseMenu()
    {
        PauseMenuCanvas.SetActive(false);
        if (TimerScript.TimerHasStarted == true)
        {
            TimerScript.TimerPaused = false;
        }

    }
}
