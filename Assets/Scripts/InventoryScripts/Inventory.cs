using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryScripts{
    public class Inventory : MonoBehaviour
    {
        public GameObject currentSelectedSlot {get; set; }
        public GameObject previousSelectedSlot {get; set; }

        private GameObject slots;
        void Start(){
            InitializeInventory();
            slots = GameObject.Find("Slots");
        }
        void Update(){
            SelectSlot();
        }

        // Fills the inventory slots with empty_item -sprite
        // ItemProperties of empty slots are empty by default
        // Call this method from start
        void InitializeInventory(){
            var slots = GameObject.Find("Slots");
            foreach(Transform slot in slots.transform){
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
                slot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            }
        }

        // Shows user what slot is currently selected and deselects slots in certain cases
        // Call from update
        void SelectSlot(){
            foreach(Transform slot in slots.transform){
                
                // If a slot is already selected and tapped again, nullify the current and previous slots to deselect them
                if(slot.gameObject == currentSelectedSlot && slot.gameObject == previousSelectedSlot){
                    currentSelectedSlot = null;
                    previousSelectedSlot = null;
                }
                // When a slot is selected and the object in it is usable or reusable, change the color to inform the user what object is currently selected
                else if(slot.gameObject == currentSelectedSlot && (slot.GetComponent<Slot>().ItemProperty == Slot.property.usable || slot.GetComponent<Slot>().ItemProperty == Slot.property.reUsable)) {
                    slot.GetComponent<Image>().color = new Color(.9f, .4f, .6f, 1);
                }
                // When object is used, nullify the current and previous slots to deselect the slot (otherwise it selects the slot automatically when an object is picked up)
                else if(slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.empty){
                    currentSelectedSlot = null;
                    previousSelectedSlot = null;
                }
                // If no slot is selected, don't change the color!
                else{
                    slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
            }
        }
    }
}