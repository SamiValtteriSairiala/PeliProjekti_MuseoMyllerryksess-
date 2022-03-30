using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PuzzleScript;

public class OpenTilePuzzle : MonoBehaviour
{
    [SerializeField] private Puzzle PuzzleScript;
    // Start is called before the first frame update
    void Start()
    {
        PuzzleScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
