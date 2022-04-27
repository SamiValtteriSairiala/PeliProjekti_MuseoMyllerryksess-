using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;

public class LobbyMove : MonoBehaviour
{
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject SecondFloor;
    [SerializeField] private GameObject WirePuzzle;
    [SerializeField] private GameObject ElectricBox;
    private GameObject inventory;

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
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveRight()
    {
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            LobbyScreen.SetActive(false);
            BlackScreenScript.BlackenScreen();
            BlackScreenScript.PlayStep();
            CloakRoom.SetActive(true);
            Debug.Log("Switching scene");
        }
    }

    public void MoveUp()
    {
        // Only able to go to upstairs after timer starts.
        if (TimerScript.TimerPaused == false && inventory.GetComponent<Inventory>().currentSelectedSlot == null)
        {
            LobbyScreen.SetActive(false);
            BlackScreenScript.BlackenScreen();
            BlackScreenScript.PlayStep();
            SecondFloor.SetActive(true);
        }

    }

    public void OpenWirePuzzle()
    {
        if (TimerScript.TimerPaused == false && inventory.GetComponent<Inventory>().currentSelectedSlot == null)
        {
            ElectricBox.SetActive(true);
            LobbyScreen.SetActive(false);
        }
    }
    public void BackToLobby()
    {
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            ElectricBox.SetActive(false);
            BlackScreenScript.BlackenScreen();
            LobbyScreen.SetActive(true);
        }
    }



}
