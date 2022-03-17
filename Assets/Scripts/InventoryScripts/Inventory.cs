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

        // Fill the inventory slots with empty_item -sprite
        // Call this method from start
        void InitializeInventory(){
            var slots = GameObject.Find("Slots");
            foreach(Transform slot in slots.transform){
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
            }
        }

        // Show user what slot is currently selected
        // TODO! Change the color after UI is ready
        // Call from update
        void SelectSlot(){
            foreach(Transform slot in slots.transform){
                // When slot is selected, change the color
                if(slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.usable && slot.transform.GetChild(0).GetComponent<Image>().sprite.name != "empty_item"){
                    slot.GetComponent<Image>().color = new Color(.9f, .4f, .6f, 1);
                }
                // If not selected, don't change it!
                else{
                    slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
            }
        }
    }
}