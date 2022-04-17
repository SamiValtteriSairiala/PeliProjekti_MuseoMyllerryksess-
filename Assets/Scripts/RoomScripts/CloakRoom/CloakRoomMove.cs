using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CloakRoomMove : MonoBehaviour
{
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject SafetyBox;
    [SerializeField] private GameObject CloakRoomImage;

    private GameObject GameManager;
    private BlackScreen BlackScreenScript;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        BlackScreenScript = GameManager.GetComponent<BlackScreen>();
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
        CloakRoom.SetActive(false);
        BlackScreenScript.BlackenScreen();
        BlackScreenScript.PlayStep();
        LobbyScreen.SetActive(true);
    }


    public void OpenSafetyBox(){
        SafetyBox.SetActive(true);
        BlackScreenScript.BlackenScreen();
        BlackScreenScript.PlayStep();
        CloakRoomImage.SetActive(false);
    }

    public void BackToCloakRoom(){
        CloakRoomImage.SetActive(true);
        BlackScreenScript.BlackenScreen();
        BlackScreenScript.PlayStep();
        SafetyBox.SetActive(false);
    }
}
