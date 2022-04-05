using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPuzzle : MonoBehaviour
{

    [SerializeField] private GameObject StartPiece;
    [SerializeField] private GameObject StartPiece2;
    [SerializeField] private GameObject StartPiece3;
    public bool restart = false;
    public float speed;
    private Vector2 targetPosition;
    private Vector2 currentPos;

    [SerializeField] private GoalPath GoalPiece;

    [SerializeField] private GameObject FirstNumber;
    [SerializeField] private GameObject SecondNumber;
    [SerializeField] private GameObject ThirdNumber;


    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2(transform.position.x, transform.position.y);

    }

   

    // Update is called once per frame
    void FixedUpdate()
    {



        if (Input.GetMouseButtonDown(0))
        {
            currentPos = this.transform.position;
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        if (restart == false)
        {
            
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);

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

            }
        }
         if (ThirdNumber.activeInHierarchy == true)
        {


            //Resets player to start piece.
            if (restart == true)
            {

                targetPosition = new Vector2(StartPiece3.transform.position.x, StartPiece3.transform.position.y);
                gameObject.transform.position = StartPiece3.transform.position;
                restart = false;

            }
        }


    }

}
