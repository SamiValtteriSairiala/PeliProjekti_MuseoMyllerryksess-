using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPath : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private GameObject PathPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        // Change sprite.                      
        ChangeSprite();
        // Correct move.
        //Add something here that happens when winning.
        PathPuzzle.SetActive(false);

    }
    void ChangeSprite(){
        spriteRenderer.sprite = newSprite;
    }
}
