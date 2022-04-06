using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;
using UnityEngine.UI;

public class ChangePainting : MonoBehaviour, IInteractable
{
    public string UnlockItem;
    [SerializeField] private GameObject toActivate;
    [SerializeField] private GameObject toActivate2;
    [SerializeField] private GameObject toDestroy;
    [SerializeField] private GameObject checkIfDestroyed1;
    [SerializeField] private GameObject checkIfDestroyed2;
    //[SerializeField] private GameObject checkIfDestroyed3;
    [SerializeField] private GameObject toFinish;
    private GameObject inventory;

    public void Interact()
    {
        // First check that the item has usable property and the selected slot is not null
            if(inventory.GetComponent<Inventory>().currentSelectedSlot != null && inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.property.usable){
            // If item needed to unlock the box is same as the selected item
                if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
                
                    // When an object interacts with another gameobject it is supposed to, change item sprite back to empty_item
                    inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                    inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
                    Debug.Log("Unlocked");
                    
                    if(checkIfDestroyed1 == null && checkIfDestroyed2 == null){
                        toFinish.SetActive(true);
                    }
                    toActivate.SetActive(true);
                    toActivate2.SetActive(true);
                    Destroy(toDestroy);
                }
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
