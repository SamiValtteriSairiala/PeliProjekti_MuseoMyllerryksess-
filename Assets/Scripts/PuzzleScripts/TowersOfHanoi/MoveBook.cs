using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Hanoi{
public class MoveBook : MonoBehaviour, IInteractable
{
    // currently selected book
    public static Transform currentBook;

    // the parent where the book currently exists
    private Transform currentPile;


    // Selects a book if it is on top of the pile (meaning it is the smallest book there is)
    public void Interact()
    {
        
        currentPile = transform.parent;
        Debug.Log("current pile " + currentPile);

            
            // If there is only 1 book on the pile, the book can be moved
            if(currentPile.childCount == 1){
                currentBook = gameObject.GetComponent<Transform>();
                Debug.Log("current book " + currentBook);
            }

            // If there is 5 books on the pile, only the smallest ("book_0") can be moved
            else if (currentPile.childCount == 5 && gameObject.name == "book_0"){
                currentBook = gameObject.GetComponent<Transform>();
                Debug.Log("current book " + currentBook);
            }

            // If there are 2 books on the pile, only the smaller one can be moved
            else if(currentPile.childCount == 2 && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(0).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(1).GetComponent<RectTransform>().rect.width){
                
                currentBook = gameObject.GetComponent<Transform>();
                Debug.Log("current book " + currentBook);
            }
            // If there are 3 books on the pile, only the smallest one can be moved
            else if(currentPile.childCount == 3 && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(0).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(1).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(2).GetComponent<RectTransform>().rect.width){
                
                currentBook = gameObject.GetComponent<Transform>();
                Debug.Log("current book " + currentBook);
            }
            // If there are 4 books on the pile, only the smallest one can be moved
            else if(currentPile.childCount == 4 && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(0).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(1).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(2).GetComponent<RectTransform>().rect.width
            && gameObject.GetComponent<RectTransform>().rect.width <= currentPile.GetChild(3).GetComponent<RectTransform>().rect.width){
                
                currentBook = gameObject.GetComponent<Transform>();
                Debug.Log("current book " + currentBook);
            }









        
        
    }

}
}