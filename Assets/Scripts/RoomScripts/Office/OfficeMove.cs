using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;

public class OfficeMove : MonoBehaviour
{
    [SerializeField] private GameObject OfficeScreen;
    [SerializeField] private GameObject DownStairs;
    private GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    public void MoveBackToDownstairs()
    {
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            OfficeScreen.SetActive(false);
            DownStairs.SetActive(true);
        }
    }
}
