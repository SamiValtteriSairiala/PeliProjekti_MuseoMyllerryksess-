using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockSafetyBox : MonoBehaviour, IInteractable
{
    // Keep track of what object is needed to be selected to interact with the gameobject having this script 
    public string UnlockItem;

    private GameObject inventory;

    void Start(){
        inventory = GameObject.Find("Inventory");
    }
public void Interact()
    {
        if(inventory.GetComponent<Inventory>().currentSelectedSlot != null){
        // If item needed to unlock the box is same as the selected item
            if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
            
            // TODO! Add a preferred action here that happens when the safety box is opened!
            
            Debug.Log("Unlocked");
        }
        }
    }
}
