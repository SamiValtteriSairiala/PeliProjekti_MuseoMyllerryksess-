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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveLeft(){
        CloakRoom.SetActive(false);
        LobbyScreen.SetActive(true);
    }


    public void OpenSafetyBox(){
        SafetyBox.SetActive(true);
        CloakRoomImage.SetActive(false);
    }

    public void BackToCloakRoom(){
        CloakRoomImage.SetActive(true);
        SafetyBox.SetActive(false);
    }
}
