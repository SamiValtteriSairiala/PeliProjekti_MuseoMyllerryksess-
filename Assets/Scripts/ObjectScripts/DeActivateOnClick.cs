using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;
using UnityEngine.UI;

namespace ObjectScripts{

    public class DeActivateOnClick : MonoBehaviour, IInteractable
    {
        [SerializeField] private GameObject toDeactivate;
        [SerializeField] private GameObject toActivate;
        [SerializeField] private GameObject object1;
        [SerializeField] private GameObject object2;
        [SerializeField] private GameObject object3;
        [SerializeField] private GameObject object4;

        private GameObject inventory;

        void Start(){
            inventory = GameObject.Find("Inventory");
        }
        public void Interact()
        {
            DeActivateWhenReady();
        }

        // Deactivates gameObject this script is attached, if every object mentioned in the script is nullified
        private void DeActivateWhenReady()
        {
            // Check if every object needed to open a box is interracted with and the current slot in inventory is null to continue
            if(object1 == null && object2 == null && object3 == null && object4 == null && inventory.GetComponent<Inventory>().currentSelectedSlot == null){
                
                    Debug.Log("unlocked" + gameObject);
                    // gameObject.SetActive(false);
                    toDeactivate.SetActive(false);
                    toActivate.SetActive(true);
                
            }
        }
    }
}