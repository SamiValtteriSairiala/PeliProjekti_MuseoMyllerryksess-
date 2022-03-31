using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PuzzleScript;

public class CloseTilePuzzle : MonoBehaviour
{
    [SerializeField] private Puzzle Puzzle;
    [SerializeField] private GameObject tilepuzzle;
    [SerializeField] private GameObject UpperFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        Puzzle.enabled = false;
        tilepuzzle.SetActive(false);
        UpperFloor.SetActive(true);

    }
}
