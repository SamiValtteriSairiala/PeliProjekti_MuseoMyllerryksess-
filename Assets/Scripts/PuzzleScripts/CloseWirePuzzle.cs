using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InventoryScripts;

public class CloseWirePuzzle : MonoBehaviour
{
    [SerializeField] private GameObject Wires;
    [SerializeField] private GameObject ElectricBox;
    private GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
        Wires.SetActive(false);
        ElectricBox.SetActive(true);
        }
    }
}
