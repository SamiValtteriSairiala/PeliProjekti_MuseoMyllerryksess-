using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperFloorMove : MonoBehaviour
{
    [SerializeField] private GameObject UpperFloor;
    [SerializeField] private GameObject LobbyScreen;
        private GameObject GameManager;
    private BlackScreen BlackScreenScript;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        BlackScreenScript = GameManager.GetComponent<BlackScreen>();
    }

    public void MoveDown(){
        UpperFloor.SetActive(false);
        BlackScreenScript.BlackenScreen();
        BlackScreenScript.PlayStep();
        LobbyScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
