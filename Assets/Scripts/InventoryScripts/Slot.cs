using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerDownHandler
{
    private GameObject inventory;

    public enum property{ usable, displayable};
    public property ItemProperty{ get; private set;}
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
