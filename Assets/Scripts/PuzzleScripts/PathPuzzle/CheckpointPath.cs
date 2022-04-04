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
    [SerializeField] private GameObject WallCollider;
    [SerializeField] private GameObject ThirdNumber;


    public bool CheckPointReached = false;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
        Boat = GameObject.Find("Boat");
        StartPiece = GameObject.Find("StartPath");
        CheckPointReached = false;
        WallCollider.SetActive(false);
        if(ThirdNumber.activeInHierarchy == true){
            WallCollider.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Boat.transform.position == StartPiece.transform.position){
            Restart = true;
            Debug.Log("Resetting to orginal");
        }
        if(Restart == true){
            spriteRenderer.color = Color.white;
            CheckPointReached = false;
            Restart = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        CheckPointReached = true;
        if(ThirdNumber.activeInHierarchy == true){
            WallCollider.SetActive(false);
        }
        // Change sprite.
        ChangeSprite();
        // Correct move.
    }
    void ChangeSprite(){
        spriteRenderer.color = Color.green;
    }
}
