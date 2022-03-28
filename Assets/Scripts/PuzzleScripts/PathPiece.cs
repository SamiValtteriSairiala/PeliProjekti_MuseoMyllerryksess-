using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPiece : MonoBehaviour
{


    private BoxCollider2D BC2D;
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        BC2D = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
        // Change sprite.
        ChangeSprite();
        // Correct move.
    }
    void ChangeSprite(){
        spriteRenderer.sprite = newSprite;
    }
}
