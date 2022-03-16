using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.EventSystems;

public class Interact : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if(transform.tag == "Interactable"){
                transform.GetComponent<IInteractable>().Interact();

                Debug.Log("hit");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0)){
            Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPosition,Vector2.zero,100);

            if(hit&& hit.transform.tag == "Interactable"){
                hit.transform.GetComponent<IInteractable>().Interact();
                Debug.Log("hit");
            }
        }*/
    }
}
