using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideMove : MonoBehaviour
{
    [SerializeField] private GameObject OutsideScreen;
    [SerializeField] private GameObject LobbyScreen;
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

    public void MoveOutsideUp(){
        OutsideScreen.SetActive(false);
        BlackScreenScript.BlackenScreen();
        LobbyScreen.SetActive(true);
    }
}
