using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private GameObject MoveArrowUp;
    [SerializeField] private GameObject LobbyScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveArrowUpwards(){
        if(LobbyScreen.activeInHierarchy == true){
            LobbyScreen.active = false;
            

        }
    }
}
