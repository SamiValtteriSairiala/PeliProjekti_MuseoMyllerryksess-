using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;

namespace ObjectScripts{

    // Use for hints etc., sets the gameobject deactive when it's clicked
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
    }
}
