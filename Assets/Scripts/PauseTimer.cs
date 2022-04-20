using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseTimer : MonoBehaviour
{
    // Pauses timer and fades in text
    [SerializeField] private Timer Timer;
    [SerializeField] private Text FadeInText;
    [SerializeField] private TMP_Text finalTime;
    [SerializeField] private Image imageToFade;
    [SerializeField] private Text imageText;
    [SerializeField] private Image finalNote;
    Color textCol;
    Color imgCol;
    Color finalTimeCol;
    Color imgTextCol;
    Color finalNoteCol;
    void Start()
    {
        Timer.PauseTimer();
        textCol = FadeInText.color;
        imgCol = imageToFade.color;
        finalTimeCol = finalTime.color;
        imgTextCol = imageText.color;
        finalNoteCol = finalNote.color;
        textCol.a = 0;
        imgCol.a = 0;
        finalTimeCol.a = 0;
        imgTextCol.a = 0;
        finalNoteCol.a = 0;
        FadeInText.color = textCol;
        imageToFade.color = imgCol;
        finalTime.color = finalTimeCol;
        imageText.color = imgTextCol;
        finalNote.color = finalNoteCol;
    }
    void Update(){

        StartCoroutine(Wait());
        
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds(1);
        
        if(textCol.a < 64){
            finalNoteCol.a += Time.deltaTime/3;
            textCol.a += Time.deltaTime/3;
            imgCol.a += Time.deltaTime/3;
            finalTimeCol.a += Time.deltaTime/3;
            imgTextCol.a += Time.deltaTime/3;
            
            finalNote.color = finalNoteCol;
            FadeInText.color = textCol;
            imageToFade.color = imgCol;
            finalTime.color = finalTimeCol;
            imageText.color = imgTextCol;
        }
        else if(textCol.a >=64 && textCol.a < 256){
            finalNoteCol.a += Time.deltaTime/2;
            textCol.a += Time.deltaTime/2;
            imgCol.a += Time.deltaTime/2;
            finalTimeCol.a += Time.deltaTime/2;
            imgTextCol.a += Time.deltaTime/2;

            finalNote.color = finalNoteCol;
            FadeInText.color = textCol;
            imageToFade.color = imgCol;
            finalTime.color = finalTimeCol;
            imageText.color = imgTextCol;
        }
        /*else if(col.a >=128 && col.a < 256){
            col.a += Time.deltaTime/2;
            FadeInText.color = col;
        }*/
    }
}
