using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;

public class RoomsManager : MonoBehaviour
{
    [SerializeField] private GameObject WirePuzzle;
    [SerializeField] private GameObject LobbyScreen;
    [SerializeField] private GameObject CloakRoomScreen;
    [SerializeField] private GameObject DownStairsScreen;

    [SerializeField] private GameObject Shadow;
    private GameObject inventory;
    private bool CanGoDown = false;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
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

    public void WirePuzzleComplete()
    {
        Destroy(Shadow);
        Debug.Log("Shadow destroyed");
        CanGoDown = true;

    }

    void DeactivateWirePuzzle(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            WirePuzzle.SetActive(false);
            LobbyScreen.SetActive(true);
        }
    }
    public void MoveToDownstairs()
    {
        if (CanGoDown == true && inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            CloakRoomScreen.SetActive(false);
            DownStairsScreen.SetActive(true);
        }


    }
}
