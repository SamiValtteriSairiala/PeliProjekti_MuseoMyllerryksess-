using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;

namespace ObjectScripts{
    public class CloseOnClick : MonoBehaviour, IInteractable
    {

        public void Interact()
        {
            CloseExamine();
        }

        private void CloseExamine()
        {
            gameObject.SetActive(false);
        }

        void Start(){
            
        }

    }
}
