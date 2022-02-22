using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private GameObject LockedText;
    // Add all "playable rooms" here
    [SerializeField] private GameObject OutsideScreen;
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject UpperFloor;
    [SerializeField] private GameObject Cloakroom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveArrowUpwards(){
        //When pressed arrow pointing upwards then check what "scene" is active and change it to next one.
        if(OutsideScreen.activeInHierarchy == true){
            OutsideScreen.SetActive(false);
            LobbyScreen.SetActive(true);
        }


        if(LobbyScreen.activeInHierarchy == true){
            LobbyScreen.SetActive(false);
            UpperFloor.SetActive(true);  
        }
    }

    void MoveArrowRight(){
         //When pressed arrow pointing right then check what "scene" is active and change it to next one.
        if(LobbyScreen.activeInHierarchy == true){
            LobbyScreen.SetActive(false);
            Cloakroom.SetActive(true);
        }

    }
    
    void MoveArrowLeft(){
        //When pressed arrow pointing left then check what "scene" is active and change it to next one.
        if(Cloakroom.activeInHierarchy == true){
            Cloakroom.SetActive(false);
            LobbyScreen.SetActive(true);
        }
    }

    void MoveArrowDown(){
        if(UpperFloor.activeInHierarchy == true){
            UpperFloor.SetActive(false);
            LobbyScreen.SetActive(true);
        }

        if(LobbyScreen.activeInHierarchy == true){
            LockedText.SetActive(true);
            //Show text for 5 seconds, then disab
            Invoke("DisableText", 5f);
        }
    }

    void DisableText(){
        LockedText.SetActive(false);
    }
}
