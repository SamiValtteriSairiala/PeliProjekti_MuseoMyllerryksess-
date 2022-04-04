using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Hanoi{

    // TODO! HARD CODED WIDTH SHOULD BE REPLACED!

public class ChangePile : MonoBehaviour, IInteractable
{
    // Pile where the selected book will move
    private Transform newPile;
    [SerializeField] private GameObject toActivate;
    //[SerializeField] private GameObject toDeactivate;
    
        public void Interact()
        {
            newPile = gameObject.GetComponent<Transform>();
            
            MoveToPile();
        }

        public void MoveToPile(){
            
            // When a book is selected change the pile with given conditions

            if(MoveBook.currentBook != null){
                var bookPosition = MoveBook.currentBook.GetComponent<RectTransform>();
                var pos = bookPosition.anchoredPosition;

                // When the pile is empty the book will be in the lowest position
                if(gameObject.transform.childCount == 0){
                    MoveBook.currentBook.SetParent(newPile, false);
                    bookPosition.anchoredPosition = new Vector3(pos.x, 0);
 
                    MoveBook.currentBook = null;
                }
                // When 1 book in pile, the book will be on top of it
                else if(gameObject.transform.childCount == 1 && bookPosition.rect.width < gameObject.transform.GetChild(0).GetComponent<RectTransform>().rect.width){
                    MoveBook.currentBook.SetParent(newPile, false);
                    bookPosition.anchoredPosition = new Vector3(pos.x, 50);

                    MoveBook.currentBook = null;
                }
                // When 2 books in pile, the book will come on top
                else if(gameObject.transform.childCount == 2 && bookPosition.rect.width < gameObject.transform.GetChild(1).GetComponent<RectTransform>().rect.width){
                    MoveBook.currentBook.SetParent(newPile, false);
                    bookPosition.anchoredPosition = new Vector3(pos.x, 100);

                    MoveBook.currentBook = null;
                }
                // When 3 books in pile, the book will come on top

                else if(gameObject.transform.childCount == 3 && bookPosition.rect.width < gameObject.transform.GetChild(2).GetComponent<RectTransform>().rect.width){
                    MoveBook.currentBook.SetParent(newPile, false);
                    bookPosition.anchoredPosition = new Vector3(pos.x, 150);

                    MoveBook.currentBook = null;
                }
                // When 4 books in pile, the book will come on top

                else if(gameObject.transform.childCount == 4 && bookPosition.rect.width < gameObject.transform.GetChild(3).GetComponent<RectTransform>().rect.width){
                    MoveBook.currentBook.SetParent(newPile, false);
                    bookPosition.anchoredPosition = new Vector3(pos.x, 200);

                    MoveBook.currentBook = null;
                }
            }
            // if no book is selected, do nothing but debug for info
            else{
                Debug.Log("no book selected");
            }
            // Check if the object has 5 children (meaning a win)
            if(GameObject.Find("BookshelfClickbox3").transform.childCount == 5){
                Debug.Log("laaatiiinooooooo breeeeiiik?");
                toActivate.SetActive(true);
                // toDeactivate.SetActive(false);
                

                // TODO! do the win dance (aka latino break)
        }
            else{
                Debug.Log("ku ei nii ei");

                // don't do it (latino break stop)
            }
        }
       
}
}