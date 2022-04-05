using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNumberLockDownStairs : MonoBehaviour
{
    [SerializeField] private GameObject Numberlock;
    [SerializeField] private GameObject DownStairs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToDownStairs(){
        Numberlock.SetActive(false);
        DownStairs.SetActive(true);
    }

    void OnMouseDown(){
        Numberlock.SetActive(true);
        DownStairs.SetActive(false);
    }
}
