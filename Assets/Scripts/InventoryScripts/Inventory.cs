using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    void InitializeInventory(){
        var slots = GameObject.Find("Slots");
        foreach(Transform slot in slots.transform){
            slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory Items/empty_item");
        }
    }
    void SelectSlot(){
        foreach(Transform slot in slots.transform){
            if(slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.usable){
                slot.GetComponent<Image>().color = new Color(.9f, .4f, .6f, 1);
            }
            else{
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}
