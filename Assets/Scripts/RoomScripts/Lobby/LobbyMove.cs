using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMove : MonoBehaviour
{
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject SecondFloor;
    [SerializeField] private GameObject WirePuzzle;
    [SerializeField] private GameObject ElectricBox;

    // Start is called before the first frame update
    private GameObject GameManager;
    private BlackScreen BlackScreenScript;

    private Timer TimerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        BlackScreenScript = GameManager.GetComponent<BlackScreen>();
        TimerScript = GameManager.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveRight()
    {
        LobbyScreen.SetActive(false);
        BlackScreenScript.BlackenScreen();
        CloakRoom.SetActive(true);
        Debug.Log("Switching scene");
    }

    public void MoveUp()
    {
        // Only able to go to upstairs after timer starts.
        if (TimerScript.TimerPaused == false)
        {
            LobbyScreen.SetActive(false);
            BlackScreenScript.BlackenScreen();
            SecondFloor.SetActive(true);
        }

    }

    public void OpenWirePuzzle()
    {
        if (TimerScript.TimerPaused == false)
        {
            ElectricBox.SetActive(true);
            LobbyScreen.SetActive(false);
        }
    }
    public void BackToLobby()
    {
        ElectricBox.SetActive(false);
        BlackScreenScript.BlackenScreen();
        LobbyScreen.SetActive(true);
    }



}
