using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InventoryScripts;


public class TimerClock : MonoBehaviour, IInteractable
{
    
    [SerializeField ] private Timer Timer;
    // Start is called before the first frame update
   
    public void Interact()
    {
        Timer.StartTimer();
        
    }
}
