using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongPathPiece : MonoBehaviour
{
    private BoxCollider2D bc2d;
    private PathPuzzle PathPuzzle;
    private GameObject PathManager;
    private bool CollectedThis = false;
    // Start is called before the first frame update
    void Start()
    {
        PathPuzzle = FindObjectOfType<PathPuzzle>();
        bc2d = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Resets player
        // PathPuzzle.restart = true;
        if(CollectedThis == false){

       
        PathPuzzle.CorrectTile --;
        CollectedThis = true;
         }

        Debug.Log("Player touched wrong piece ");

    }
}
