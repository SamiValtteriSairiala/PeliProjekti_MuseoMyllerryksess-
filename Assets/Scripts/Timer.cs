using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Timer : MonoBehaviour
{
    //henkka on poika
    public float Seconds = 0;
    public float minutes = 0;

    public float hour = 8;
    public TMP_Text TimerText;
    public bool TimerPaused = true;
    public bool TimerHasStarted = false;

    [SerializeField] GameObject TimerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        TimerPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerPaused == false){
            Seconds += Time.deltaTime;
        }
        if(Seconds >= 60f){
            minutes += 1;
            Seconds = 0;
        }
        if(minutes >= 60f){
            hour += 1;
            minutes = 0;
        }
        TimerText.text = hour.ToString("00") + ":" + minutes.ToString("00");
        
    }
    public void StartTimer(){
        TimerCanvas.SetActive(true);
        TimerHasStarted = true;
        TimerPaused = false;
        
    }

    
}
