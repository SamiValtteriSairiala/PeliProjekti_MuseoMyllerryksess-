using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InventoryScripts;

namespace ObjectScripts{
    public class UnlockAndDestroy : MonoBehaviour, IInteractable
    {
        // Keep track of what object is needed to be selected to interact with the gameobject having this script 
        public string UnlockItem;

        [SerializeField] private GameObject toDestroy;

        [SerializeField] private GameObject interractableObject1;
        [SerializeField] private GameObject interractableObject2;
        [SerializeField] private GameObject interractableObject3;
        [SerializeField] private GameObject interractableObject4;
        private GameObject inventory;


        void Start(){
            inventory = GameObject.Find("Inventory");
            
        }
    public void Interact()
        {
            // First check that the item has usable property and the selected slot is not null
            if(inventory.GetComponent<Inventory>().currentSelectedSlot != null && inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.property.usable){
            // If item needed to unlock the box is same as the selected item
                if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
                
                    // When an object interacts with another gameobject it is supposed to, change item sprite back to empty_item
                    inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                    inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
                    Debug.Log("Unlocked");
                    
                    Destroy(toDestroy);
                    //Destroy(gameObject);
                }
            }
            // If object is reUsable, don't rewrite the slot sprite before every interractable has been nullified
            else if (inventory.GetComponent<Inventory>().currentSelectedSlot != null && inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.property.reUsable){
                if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
                    

                    // Check that every object is nullified before changing the sprite
                    if((interractableObject1 == null && interractableObject2 == null && interractableObject3 == null) || (interractableObject1 == null && interractableObject2 == null && interractableObject4 == null) ||
                       (interractableObject1 == null && interractableObject3 == null && interractableObject4 == null) || (interractableObject2 == null && interractableObject3 == null && interractableObject4 == null)){
                        
                        // When an object interacts with the last interractable gameobject it is supposed to, change item sprite back to empty_item
                        inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                        inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
                    }
                    Debug.Log("Unlocked");
                    Destroy(toDestroy);
                }
            }
        }
    }
}