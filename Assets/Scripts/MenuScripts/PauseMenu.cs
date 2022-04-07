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
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenuCanvas.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePauseMenu();
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
