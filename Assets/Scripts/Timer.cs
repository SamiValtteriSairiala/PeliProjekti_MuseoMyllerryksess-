using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Timer : MonoBehaviour
{
    //henkka on poika
    public float timer = 0;
    public float minutes = 0;
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
            timer += Time.deltaTime;
        }
        if(timer >= 60f){
            minutes += 1;
            timer = 0;
        }
        TimerText.text = minutes.ToString("00") + ":" + timer.ToString("00");
        
    }
    public void StartTimer(){
        TimerCanvas.SetActive(true);
        TimerHasStarted = true;
        TimerPaused = false;
        
    }

    
}
