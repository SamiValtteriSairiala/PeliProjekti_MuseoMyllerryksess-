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
    private GoalPath GoalScripts;
    [SerializeField] private GameObject ThirdNumber;
    private PathPuzzle PathPuzzle;


    public bool CheckPointReached = false;
    private bool CollectedThis = false;
    // Start is called before the first frame update
    void Awake()
    {
        PathPuzzle = FindObjectOfType<PathPuzzle>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
        Boat = GameObject.Find("Boat");
        StartPiece = GameObject.Find("StartPath");
        CheckPointReached = false;
        GoalScripts = FindObjectOfType<GoalPath>();
        WallCollider.SetActive(false);
        // if(ThirdNumber.activeInHierarchy == true){
        //     WallCollider.SetActive(true);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if(Boat.transform.position == StartPiece.transform.position){
            Restart = true;
            Debug.Log("Resetting to orginal");
        }
        if(Restart == true){
            // spriteRenderer.color = Color.white;
            CheckPointReached = false;
            CollectedThis = false;
            Restart = false;
        }
        if (GoalScripts.GreenTile == true)
        {
            ChangeSprite();
        }
        if (GoalScripts.GreenTile == false)
        {
            spriteRenderer.color = Color.white;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(CollectedThis == false){
            CheckPointReached = true;
            PathPuzzle.CorrectTile ++;
            CollectedThis = true;
        }
        // Change sprite.
        // ChangeSprite();
        // Correct move.
    }
    void ChangeSprite(){
        spriteRenderer.color = Color.green;
    }
}
