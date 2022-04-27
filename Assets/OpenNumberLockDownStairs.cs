using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;

public class OpenNumberLockDownStairs : MonoBehaviour
{
    [SerializeField] private GameObject Numberlock;
    [SerializeField] private GameObject DownStairs;

    [SerializeField] private GameObject LobbyScreen;
     [SerializeField] private GameObject NumberLockLobby;
     private GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToDownStairs(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            Numberlock.SetActive(false);
            DownStairs.SetActive(true);
        }
    }

    public void CloseNumlockLObby(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            LobbyScreen.SetActive(true);
            NumberLockLobby.SetActive(false);
        }
    }
    void OnMouseDown(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            Numberlock.SetActive(true);
            DownStairs.SetActive(false);
        }
    }
}
