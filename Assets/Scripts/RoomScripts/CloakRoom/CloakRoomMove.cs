using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloakRoomMove : MonoBehaviour
{
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject LobbyScreen;

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
}
