using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPath : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite currentSprite;
    [SerializeField] private GameObject WholePathPuzzle;
    [SerializeField] private GameObject FirstNumber;
    [SerializeField] private GameObject SecondNumber;
    [SerializeField] private GameObject ThirdNumber;

    [SerializeField] private GameObject FirstNumber1;
    [SerializeField] private GameObject SecondNumber7;
    [SerializeField] private GameObject ThirdNumber4;
    [SerializeField] private GameObject DownStairs;
    [SerializeField] private GameObject boat;

    public bool ReachedGoal1 = false;
    public bool ReachedGoal2 = false;
    public bool ReachedGoal3 = false;

    [SerializeField] private PathPuzzle PathPuzzle;

    [SerializeField] private CheckpointPath checkPoint;
    // Start is called before the first frame update
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
                if (PathPuzzle.CorrectTile == 3)
                {


                    FirstNumber1.SetActive(true);
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    Invoke("ChangeToSecond", 0.1f);
                    PathPuzzle.CorrectTile = 0;
                    PathPuzzle.WrongTile = 0;
                    ReachedGoal1 = true;
                    PathPuzzle.restart = true;
                }
            }
            if (SecondNumber.activeInHierarchy == true)
            {
                if (PathPuzzle.CorrectTile == 5)
                {


                    FirstNumber1.SetActive(true);
                    SecondNumber7.SetActive(true);
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    Invoke("ChangeToThird", 0.1f);
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


                    FirstNumber1.SetActive(true);
                    SecondNumber7.SetActive(true);
                    ThirdNumber4.SetActive(true);
                    PathPuzzle.CorrectTile = 0;
                    PathPuzzle.WrongTile = 0;
                    Debug.Log("Goal!");
                    // Change sprite.                      
                    // ChangeSprite();
                    // Correct move.
                    //Add something here that happens when winning.
                    ReachedGoal3 = true;
                    boat.SetActive(true);
                }

            }
        }


    }


    void ChangeToSecond()
    {
        FirstNumber.SetActive(false);
        SecondNumber.SetActive(true);
    }

    void ChangeToThird()
    {
        SecondNumber.SetActive(false);
        ThirdNumber.SetActive(true);
    }
    public void ClosePuzzle()
    {
        WholePathPuzzle.SetActive(false);
        DownStairs.SetActive(true);
    }
    void ChangeSprite()
    {
        spriteRenderer.color = Color.green;
    }
}
