using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.EventSystems;

public class Interact : MonoBehaviour, IPointerDownHandler
{
    // Use when user clicks/touches an interactable object
    public void OnPointerDown(PointerEventData eventData)
    {
        if(transform.tag == "Interactable"){
                transform.GetComponent<IInteractable>().Interact();

                // Message to console on a confirmed hit
                Debug.Log("hit");
        }
    }
}
