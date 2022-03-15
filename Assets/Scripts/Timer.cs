using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float timer = 0;
    public float minutes = 0;
    public Text TimerText;
    public bool TimerPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
