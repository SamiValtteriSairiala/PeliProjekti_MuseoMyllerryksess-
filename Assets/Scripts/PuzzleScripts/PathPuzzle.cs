using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPuzzle : MonoBehaviour
{

    [SerializeField] private GameObject StartPiece;
    public bool restart = false;
    public float speed;
    private Vector2 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        if (restart == false)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);
        }

        //Resets player to start piece.
        if (restart == true)
        {
            targetPosition = new Vector2(StartPiece.transform.position.x, StartPiece.transform.position.y);
            gameObject.transform.position = StartPiece.transform.position;
            restart = false;
        }
    }
}
