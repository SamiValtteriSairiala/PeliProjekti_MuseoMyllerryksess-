using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// To determine what is the current selected slot

namespace InventoryScripts{
    public class Slot : MonoBehaviour, IPointerDownHandler
    {
        private GameObject inventory;

        public enum property{ usable, displayable, empty};
        public property ItemProperty{ get; set;}
        void Start(){
            inventory = GameObject.Find("Inventory");
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            inventory.GetComponent<Inventory>().previousSelectedSlot = inventory.GetComponent<Inventory>().currentSelectedSlot;
            inventory.GetComponent<Inventory>().currentSelectedSlot = this.gameObject;
        }
        public void AssignProperty(int orderNumber){
            ItemProperty = (property)orderNumber;
        }
    }
}