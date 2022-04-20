using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouSure : MonoBehaviour
{
    [SerializeField] private GameObject askPlayer;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject sure;
    [SerializeField] private GameObject notSure;
    

    // Sets Pop up menu active, player can choose if they want to continue game or go back to main menu
    public void PopUp(){
        askPlayer.SetActive(true);
        pauseMenu.SetActive(false);
    }

    // If player wants to continue playing, goes back to pause menu
    public void BacktoPauseMenu(){

        askPlayer.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
