using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using InventoryScripts;

public class GoalPath : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite currentSprite;
    [SerializeField] private GameObject WholePathPuzzle;
    [SerializeField] private GameObject FirstNumber;
    [SerializeField] private GameObject SecondNumber;
    [SerializeField] private GameObject ThirdNumber;

    [SerializeField] private SpriteRenderer FirstNumber1;
    [SerializeField] private SpriteRenderer SecondNumber7;
    [SerializeField] private SpriteRenderer ThirdNumber4;
    [SerializeField] private GameObject DownStairs;
    [SerializeField] private GameObject boat;
    [SerializeField] private Sprite Sprite1;
    [SerializeField] private Sprite Sprite2;
    [SerializeField] private Sprite Sprite3;
    private GameObject inventory;

    public bool ReachedGoal1 = false;
    public bool ReachedGoal2 = false;
    public bool ReachedGoal3 = false;
    public Sprite KariSprite;

    public bool GreenTile = false;

    [SerializeField] private PathPuzzle PathPuzzle;

    [SerializeField] private CheckpointPath checkPoint;
    public AudioSource LaivaPuzzleAudioSource;
    public AudioSource gameCanvasAudio;
    public AudioClip Numero;
    public AudioClip Karille;
    // Start is called before the first frame update
    void Start(){
        inventory = GameObject.Find("Inventory");
    }
    void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (checkPoint.CheckPointReached == true)
        {
            if (FirstNumber.activeInHierarchy == true)
            {
                if (PathPuzzle.CorrectTile == 5)
                {

                    LaivaPuzzleAudioSource.PlayOneShot(Numero);
                    FirstNumber1.sprite = Sprite1;
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    GreenTile = true;
                    ChangeSprite();
                    
                    Invoke("ChangeToSecond", 0.3f);
                    PathPuzzle.CorrectTile = 0;
                    PathPuzzle.WrongTile = 0;
                    ReachedGoal1 = true;
                    PathPuzzle.restart = true;
                }
            }
            if (SecondNumber.activeInHierarchy == true)
            {
                if (PathPuzzle.CorrectTile == 3)
                {

                    LaivaPuzzleAudioSource.PlayOneShot(Numero);
                   FirstNumber1.sprite = Sprite1;
                   SecondNumber7.sprite = Sprite2;
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    GreenTile = true;
                    
                    ChangeSprite();
                    Invoke("ChangeToThird", 0.3f);
                    PathPuzzle.CorrectTile = 0;
                    PathPuzzle.WrongTile = 0;
                    ReachedGoal2 = true;
                    PathPuzzle.restart = true;
                }
            }
            if (ThirdNumber.activeInHierarchy == true)
            {
                if (PathPuzzle.CorrectTile == 7)
                {

                    LaivaPuzzleAudioSource.PlayOneShot(Numero);
                    FirstNumber1.sprite = Sprite1;
                   SecondNumber7.sprite = Sprite2;
                   ThirdNumber4.sprite = Sprite3;
                    PathPuzzle.CorrectTile = 0;
                    PathPuzzle.WrongTile = 0;
                    PathPuzzle.End = true;
                    Debug.Log("Goal!");
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    GreenTile = true;
                    ChangeSprite();
                    ReachedGoal3 = true;
                    boat.SetActive(true);
                }

            }
        }


    }


    void ChangeToSecond()
    {
        FirstNumber.SetActive(false);
        GreenTile = false;
        spriteRenderer.color = Color.white;
        SecondNumber.SetActive(true);
    }

    void ChangeToThird()
    {
        SecondNumber.SetActive(false);
        GreenTile = false;
        spriteRenderer.color = Color.white;
        ThirdNumber.SetActive(true);
    }
    public void ClosePuzzle()
    {
        if(ThirdNumber.activeInHierarchy == true){
            if(inventory.GetComponent<Inventory>().currentSelectedSlot == null){
            WholePathPuzzle.SetActive(false);
            gameCanvasAudio.PlayOneShot(Karille);
            DownStairs.SetActive(true);
        }
        }

            WholePathPuzzle.SetActive(false);
            DownStairs.SetActive(true);
        
    }
    void ChangeSprite()
    {
        spriteRenderer.color = Color.green;
        if(ThirdNumber.activeInHierarchy == true){
            spriteRenderer.sprite = KariSprite;
            
        }
    }
}
