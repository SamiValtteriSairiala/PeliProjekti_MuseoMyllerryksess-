using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour, IInteractable
{
    public string DisplaySprite;

    private GameObject InventorySlots;

    public void Interact()
    {
        ItemPickUp();
    }

    private void ItemPickUp()
    {
        foreach(Transform slot in InventorySlots.transform){
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "empty_item"){
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/" + DisplaySprite);
                Destroy(gameObject);
                break;
            }
        }
    }

    void Start(){
        InventorySlots = GameObject.Find("Slots");
    }
}
