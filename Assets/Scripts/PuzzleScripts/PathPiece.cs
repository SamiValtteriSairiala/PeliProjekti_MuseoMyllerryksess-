using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPiece : MonoBehaviour
{


    private BoxCollider2D BC2D;
     public Sprite currentSprite;
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public PathPuzzle PathManager;
    private GameObject StartPiece;
    public GameObject Boat;
    public bool Restart = false;
    // Start is called before the first frame update
    void Start()
    {
        BC2D = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
        Boat = GameObject.Find("Boat");
        PathManager = Boat.GetComponent<PathPuzzle>();
        StartPiece = GameObject.Find("StartPath");
    }

    // Update is called once per frame
    void Update()
    {
        if(Boat.transform.position == StartPiece.transform.position){
            Restart = true;
            Debug.Log("Resetting to orginal");
        }
        if(Restart == true){
            spriteRenderer.sprite = currentSprite;
            Restart = false;
        }
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
