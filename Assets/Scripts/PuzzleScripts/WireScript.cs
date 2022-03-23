using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WireScript : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    // private bool isRotating = false;
    public float[] correctRotation;
    int PossibleRots = 1;
    public bool isCorrectPlaced = false;
    public WirePuzzleManager Manager;
    // Start is called before the first frame update

    void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        if (PossibleRots >= 2)
        {
            if (Mathf.Approximately(transform.eulerAngles.z, correctRotation[0]) || Mathf.Approximately(transform.eulerAngles.z, correctRotation[1]))
            {
                Debug.Log("Start Correct");
                isCorrectPlaced = true;
                Manager.CorrectMove();
            }

            // if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
            // {
            //     Debug.Log("Start Correct");
            //     isCorrectPlaced = true;
            //     Manager.CorrectMove();

            // }

        }
        else
        {
            if (Mathf.Approximately(transform.eulerAngles.z, correctRotation[0]))
            {
                Debug.Log("L piece start correct");
                isCorrectPlaced = true;
                Manager.CorrectMove();
            }
        }
        // else
        // {
        //     if (transform.eulerAngles.z == correctRotation[0])
        //     {
        //         Debug.Log("L piece start correct");
        //         isCorrectPlaced = true;
        //         Manager.CorrectMove();
        //     }
        // }

    }





    // Update is called once per frame
    void Update()
    {




    }


    private void OnMouseDown()
    {
        // isRotating = true;
        transform.Rotate(new Vector3(0, 0, 90f));
        if (PossibleRots > 1)
        {
            // if (transform.eulerAngles.z == correctRotation[0] && isCorrectPlaced == false || transform.eulerAngles.z == correctRotation[1] && isCorrectPlaced == false)
            if(Mathf.Approximately(transform.eulerAngles.z, correctRotation[0]) && isCorrectPlaced == false || Mathf.Approximately(transform.eulerAngles.z, correctRotation[1]) && isCorrectPlaced == false)
            {
                isCorrectPlaced = true;
                Manager.CorrectMove();
            }
            else if (isCorrectPlaced == true)
            {
                isCorrectPlaced = false;
                Manager.WrongMove();
            }
        }
        else
        {
            // if (transform.eulerAngles.z == correctRotation[0] && isCorrectPlaced == false)
            if(Mathf.Approximately(transform.eulerAngles.z, correctRotation[0]) && isCorrectPlaced == false)
            {
                isCorrectPlaced = true;
                Manager.CorrectMove();
            }
            else if (isCorrectPlaced == true)
            {
                isCorrectPlaced = false;
                Manager.WrongMove();
            }
        }
    }
    // void Rotate(RaycastHit2D Hit)
    // {
    //     isRotating = true;
    //     Hit.transform.Rotate(new Vector3(0, 0, 5.625f));
    //     if (PossibleRots > 1)
    //     {
    //         if (Hit.transform.eulerAngles.z == correctRotation[0] || Hit.transform.eulerAngles.z == correctRotation[1] && isCorrectPlaced == false)
    //         {
    //             isCorrectPlaced = true;
    //             Manager.CorrectMove();
    //         }
    //         else if (isCorrectPlaced == true)
    //         {
    //             isCorrectPlaced = false;
    //             // Manager.WrongMove();
    //         }
    //     }
    //     else{
    //         if (Hit.transform.eulerAngles.z == correctRotation[0]  && isCorrectPlaced == false)
    //         {
    //             isCorrectPlaced = true;
    //             Manager.CorrectMove();
    //         }
    //         else if (isCorrectPlaced == true)
    //         {
    //             isCorrectPlaced = false;
    //             // Manager.WrongMove();
    //         }
    //     }
    //     Invoke("StopRotating", 1f);

    // }

    // void StopRotating()
    // {
    //     isRotating = false;
    // }
    // void CheckRotation(RaycastHit2D hit){
    //     if (PossibleRots > 1)
    //     {
    //         if (hit.transform.eulerAngles.z == correctRotation[0] || hit.transform.eulerAngles.z == correctRotation[1] && isCorrectPlaced == false)
    //         {
    //             isCorrectPlaced = true;
    //             Manager.CorrectMove();
    //         }
    //         else if (isCorrectPlaced == true)
    //         {
    //             isCorrectPlaced = false;
    //             // Manager.WrongMove();
    //         }
    //     }
    //     else{
    //         if (hit.transform.eulerAngles.z == correctRotation[0]  && isCorrectPlaced == false)
    //         {
    //             isCorrectPlaced = true;
    //             Manager.CorrectMove();
    //         }
    //         else if (isCorrectPlaced == true)
    //         {
    //             isCorrectPlaced = false;
    //             // Manager.WrongMove();
    //         }
    //     }
    // }
}
