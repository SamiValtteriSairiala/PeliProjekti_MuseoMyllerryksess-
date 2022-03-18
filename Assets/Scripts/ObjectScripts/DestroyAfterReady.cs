using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;
using UnityEngine.UI;

namespace ObjectScripts{
    public class DestroyAfterReady : MonoBehaviour, IInteractable
    {
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
            DestroyWhenReady();
        }

        // Destroys gameObject this script is attached to, if every object mentioned in the script is nullified
        private void DestroyWhenReady()
        {
            if(object1 == null && object2 == null && object3 == null && object4 == null && inventory.GetComponent<Inventory>().currentSelectedSlot == null){
                
                    Debug.Log("unlocked" + gameObject);
                    Destroy(gameObject);
                
            }
        }
    }
}