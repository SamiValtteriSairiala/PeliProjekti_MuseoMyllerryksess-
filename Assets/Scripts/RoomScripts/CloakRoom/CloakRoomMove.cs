using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using InventoryScripts;

public class CloakRoomMove : MonoBehaviour
{
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject SafetyBox;
    [SerializeField] private GameObject CloakRoomImage;

    private GameObject GameManager;
    private BlackScreen BlackScreenScript;
    private GameObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        BlackScreenScript = GameManager.GetComponent<BlackScreen>();
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        // If user presses back button close safetybox screen.
        if(SafetyBox.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape)){
            BackToCloakRoom();
        }
    }

    public void MoveLeft(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            CloakRoom.SetActive(false);
            BlackScreenScript.BlackenScreen();
            BlackScreenScript.PlayStep();
            LobbyScreen.SetActive(true);
        }
    }


    public void OpenSafetyBox(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            SafetyBox.SetActive(true);
            BlackScreenScript.BlackenScreen();
            BlackScreenScript.PlayStep();
            CloakRoomImage.SetActive(false);
        }
    }

    public void BackToCloakRoom(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            CloakRoomImage.SetActive(true);
            BlackScreenScript.BlackenScreen();
            BlackScreenScript.PlayStep();
            SafetyBox.SetActive(false);
        }
    }
}
