using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using UnityEngine.UI;
using System;

public class DeactivateAndExamine : MonoBehaviour, IInteractable
{
        public string UnlockItem;
        public GameObject currentSelectedSlot {get; set; }
        public GameObject previousSelectedSlot {get; set; }

        [SerializeField] private GameObject toDeactivate;
        [SerializeField] private GameObject toActivate;


        private GameObject inventory;
    void Start(){
            inventory = GameObject.Find("Inventory");
        }
    public void Interact()
    {
        OnMouseDown();
        
    }

    private void OnMouseDown()
    {
        if (inventory.GetComponent<Inventory>().currentSelectedSlot != null && inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.property.reUsable){
                if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
                    
                    // Deactivate the object that is attached if interracted with the appropriate item in inventory
                    Debug.Log("Unlocked");
                    toDeactivate.SetActive(false);
                    toActivate.SetActive(true);
                    inventory.GetComponent<Inventory>().currentSelectedSlot = null;
                    inventory.GetComponent<Inventory>().previousSelectedSlot = null;
                    
                }
        }
    }
}
