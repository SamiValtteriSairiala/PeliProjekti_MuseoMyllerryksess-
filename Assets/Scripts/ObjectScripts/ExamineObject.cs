using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using System;
using UnityEngine.UI;

namespace ObjectScripts{
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