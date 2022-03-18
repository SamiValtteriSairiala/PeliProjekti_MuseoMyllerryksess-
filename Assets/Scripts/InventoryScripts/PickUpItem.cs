using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryScripts{
    public class PickUpItem : MonoBehaviour, IInteractable
    {
        // Keeps track whether the object has usable or only displayable value
        [SerializeField] private property itemProperty;

        // Keeps track of what sprite will be shown in inventory when picking up an object
        public string DisplaySprite;

        // Use for hints etc. (items that are only viewable
        public string DisplayItem;

        // Use displayable only for viewing objects, usable for items with functions with other gameobjects
        public enum property { usable, reUsable, empty};
        
        private GameObject InventorySlots;

        // If the object is interractable, try to pick it up using ItemPickUp- method
        public void Interact()
        {
            ItemPickUp();
        }

        // If inventory has empty_item -sprite, fill the first slot available with the sprite of the picked up object
        // Destroy the game object afterwards
        private void ItemPickUp()
        {
            foreach(Transform slot in InventorySlots.transform){
                if (slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "empty_item"){
                    slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/" + DisplaySprite);
                    slot.GetComponent<Slot>().AssignProperty((int)itemProperty);
                    Destroy(gameObject);
                    break;
                }
            }
        }

        void Start(){
            InventorySlots = GameObject.Find("Slots");
        }
    }
}