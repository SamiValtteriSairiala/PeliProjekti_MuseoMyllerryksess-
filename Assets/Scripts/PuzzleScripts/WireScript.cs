using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WireScript : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    private Camera m_Camera;
    private bool isRotating = false;
    public float correctRotation;
    private bool isCorrectPlaced = false;
    private float LockRotation;
    // Start is called before the first frame update
    void Start()
    {
        m_Camera = Camera.main;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        if(transform.eulerAngles.z == correctRotation){
            isCorrectPlaced = true;
            
        }
       
    }


   
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            {
                Ray EP_Ray = m_Camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D EP_hit = Physics2D.Raycast(EP_Ray.origin, EP_Ray.direction);
                if (EP_hit)
                {
                    
                    if (EP_hit.collider != null)
                    {   
                        if(isCorrectPlaced == true){
                            Debug.Log("Is correct");    
                        }
                        if(isRotating == false){
                            Rotate(EP_hit);
                        }
                        
                        // add some values to x, y, z
                        
                    }
                }
            }
            

    }
     void Rotate(RaycastHit2D Hit){
        isRotating = true;
        Hit.transform.Rotate(new Vector3(0, 0, 5.625f));
        if(Hit.transform.eulerAngles.z == correctRotation && isCorrectPlaced == false){
            isCorrectPlaced = true;
        }
        else if(isCorrectPlaced == true){
            isCorrectPlaced = false;
        }
        Invoke("StopRotating", 0.2f);
    }

    void StopRotating(){
        isRotating = false;
    }
}
