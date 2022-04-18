using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTimer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField ] private Timer Timer;
    void Start()
    {
        Timer.PauseTimer();
    }
}
