using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsManager : MonoBehaviour
{
    [SerializeField] private GameObject WirePuzzle;
    [SerializeField] private GameObject LobbyScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WirePuzzle.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("Escape");
                WirePuzzle.SetActive(false);
                LobbyScreen.SetActive(true);
            }
        }
    }
}
