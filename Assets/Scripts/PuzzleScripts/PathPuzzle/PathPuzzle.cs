using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PathPuzzle : MonoBehaviour
{

    [SerializeField] private GameObject StartPiece;
    [SerializeField] private GameObject StartPiece2;
    [SerializeField] private GameObject StartPiece3;
    [SerializeField] private GameObject PathPuzzleGrid;
    public bool restart = false;
    public float speed;
    private Vector2 targetPosition;
    private Vector2 currentPos;
    public bool End = false;

    [SerializeField] private GoalPath GoalPiece;
    [SerializeField] private SpriteRenderer StartPieceRenderer;
    [SerializeField] private SpriteRenderer StartPiece2Renderer;
    [SerializeField] private SpriteRenderer StartPiece3Renderer;

    [SerializeField] private GameObject FirstNumber;
    [SerializeField] private GameObject SecondNumber;
    [SerializeField] private GameObject ThirdNumber;

    private GoalPath GoalScripts;

    public int CorrectTile;
    public int WrongTile;
    public AudioSource LaivaPuzzleAudioSource;
    public AudioClip Karille;
    




    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2(transform.position.x, transform.position.y);
        restart = true;
        GoalScripts = FindObjectOfType<GoalPath>();
       
    }

   

    // Update is called once per frame
    void Update()
    {

       

        if (Input.GetMouseButtonDown(0))
        {

            currentPos = this.transform.position;
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        if (restart == false)
        {
            if(End == false){
                this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);
            }
            
            // Handles boats direction in which the boat points in the correct division where user pressed.
            if(transform.position.x < targetPosition.x && ((Mathf.Abs(targetPosition.x - this.transform.position.x) > Mathf.Abs(targetPosition.y - this.transform.position.y)))){
                this.transform.localRotation = Quaternion.Euler(0 , 0 , -90);
            }
            if(transform.position.x > targetPosition.x && ((Mathf.Abs(targetPosition.x - this.transform.position.x) > Mathf.Abs(targetPosition.y - this.transform.position.y)))){
                this.transform.localRotation = Quaternion.Euler(0 , 0 , 90);
            }
            if(transform.position.y < targetPosition.y && ((Mathf.Abs(targetPosition.x - this.transform.position.x) < Mathf.Abs(targetPosition.y - this.transform.position.y)))){
                this.transform.localRotation = Quaternion.Euler(0 , 0 , 0);
            }
            if(transform.position.y > targetPosition.y && ((Mathf.Abs(targetPosition.x - this.transform.position.x) < Mathf.Abs(targetPosition.y - this.transform.position.y)))){
                this.transform.localRotation = Quaternion.Euler(0 , 0 , -180);
            }
        
        }
        if (FirstNumber.activeInHierarchy == true)
        {

            
            //Resets player to start piece.
            if (restart == true)
            {

                targetPosition = new Vector2(StartPiece.transform.position.x, StartPiece.transform.position.y);
                gameObject.transform.position = StartPiece.transform.position;
                restart = false;
                
                CorrectTile = 0;
                WrongTile = 0;

            }
        }
         if (SecondNumber.activeInHierarchy == true)
        {

            
            //Resets player to start piece.
            if (restart == true)
            {

                targetPosition = new Vector2(StartPiece2.transform.position.x, StartPiece2.transform.position.y);
                gameObject.transform.position = StartPiece2.transform.position;
                restart = false;
                
                CorrectTile = 0;
                WrongTile = 0;

            }
        }
         if (ThirdNumber.activeInHierarchy == true)
        {

			if (GoalScripts.ReachedGoal3)
			{
                End = true;
                LaivaPuzzleAudioSource.PlayOneShot(Karille);
			}
            //Resets player to start piece.
            if (restart == true)
            {

                targetPosition = new Vector2(StartPiece3.transform.position.x, StartPiece3.transform.position.y);
                gameObject.transform.position = StartPiece3.transform.position;
                restart = false;
                
                CorrectTile = 0;
                WrongTile = 0;

            }
        }


    }

    public void RestartButton(){
        restart = true;
    }

}
