using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PuzzleScript;
using InventoryScripts;

public class CloseTilePuzzle : MonoBehaviour
{
    [SerializeField] private Puzzle Puzzle;
    [SerializeField] private GameObject tilepuzzle;
    [SerializeField] private GameObject UpperFloor;
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

    void OnMouseDown(){
        if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            Puzzle.enabled = false;
            tilepuzzle.SetActive(false);
            UpperFloor.SetActive(true);
        }
    }
}
