using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointPath : MonoBehaviour
{
    public Sprite currentSprite;
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private GameObject StartPiece;
    public GameObject Boat;
    public bool Restart = false;

    public bool CheckPointReached = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
        Boat = GameObject.Find("Boat");
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
            CheckPointReached = false;
            Restart = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        CheckPointReached = true;
        // Change sprite.
        ChangeSprite();
        // Correct move.
    }
    void ChangeSprite(){
        spriteRenderer.sprite = newSprite;
    }
}
