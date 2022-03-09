using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMove : MonoBehaviour
{
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject CloakRoom;
    [SerializeField] private GameObject SecondFloor;
    // Start is called before the first frame update
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
        
    }

    public void MoveRight(){
        LobbyScreen.SetActive(false);
        BlackScreenScript.BlackenScreen();
        CloakRoom.SetActive(true);
    }

}