using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideMove : MonoBehaviour
{
    [SerializeField] private GameObject OutsideScreen;
    [SerializeField] private GameObject LobbyScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveOutsideUp(){
        OutsideScreen.SetActive(false);
        LobbyScreen.SetActive(true);
    }
}
