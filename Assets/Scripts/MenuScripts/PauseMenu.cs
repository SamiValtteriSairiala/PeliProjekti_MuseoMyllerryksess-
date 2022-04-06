using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuCanvas;
    private GameObject GameManager;
    private Timer TimerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        TimerScript = GameManager.GetComponent<Timer>();
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
