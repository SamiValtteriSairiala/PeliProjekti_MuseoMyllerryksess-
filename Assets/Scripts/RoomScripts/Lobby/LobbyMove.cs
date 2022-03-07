using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMove : MonoBehaviour
{
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject SecondFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRight(){
        LobbyScreen.SetActive(false);
        CloakRoom.SetActive(true);
    }

}
