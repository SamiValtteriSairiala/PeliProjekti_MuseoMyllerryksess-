using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;
using UnityEngine.UI;

namespace ObjectScripts{

    // Use for items that are ment to be viewed in larger mode (hints etc.)
    // Attach a game object and sprite name to activate a larger image of the object (doesn't need to be the same image as the object this script is attached to)
    public class ExamineObject : MonoBehaviour, IInteractable
    {
        public GameObject itemExaminer;
        public string ExaminerImage;
        public void Interact()
        {
            ItemExamine();
        }

        private void ItemExamine()
        {   
            itemExaminer.SetActive(true);
            itemExaminer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Examinable Items/" + ExaminerImage);
        }

        // Start is called before the first frame update
        void Start()
        {
            itemExaminer.SetActive(false);
            
        }
    }
}