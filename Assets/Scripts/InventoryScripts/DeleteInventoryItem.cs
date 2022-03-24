using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using UnityEngine.UI;

// Deletes a certain item from inventory when clicking an interractable object

// Use with doors etc. and make sure the player doesn't need the item anymore
public class DeleteInventoryItem : MonoBehaviour,IInteractable
{
    private GameObject slots;
    [SerializeField] private Sprite toDelete;

    public void Interact()
    {
        DeleteItem();
    }

    private void DeleteItem(){
        foreach(Transform slot in slots.transform){
            if(toDelete.name == slot.transform.GetChild(0).GetComponent<Image>().sprite.name){
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
                slot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            }
        }
    }
    void Start(){
        slots = GameObject.Find("Slots");
    }
}
