using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private GameObject rooms;
    [SerializeField] private GameObject outsideScreen;

    
    public void BackToMainButton()
    {
        gameObject.SetActive(false);
        gameCanvas.SetActive(true);
        
        foreach(Transform child in rooms.transform) {
            child.gameObject.SetActive(false);
        }
        outsideScreen.SetActive(true);

        SceneManager.LoadScene("MainMenu");
    }
}
