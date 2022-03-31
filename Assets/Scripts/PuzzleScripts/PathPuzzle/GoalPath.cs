using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPath : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite currentSprite;
    private GameObject PathPuzzle;

    [SerializeField] private CheckpointPath checkPoint;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (checkPoint.CheckPointReached == true)
        {
            // Change sprite.                      
            ChangeSprite();
            // Correct move.
            //Add something here that happens when winning.
            PathPuzzle.SetActive(false);
        }


    }
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
