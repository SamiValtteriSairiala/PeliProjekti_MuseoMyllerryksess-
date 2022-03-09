using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour
{
    public bool isBlack = false;

    [SerializeField] private GameObject BlackScreenCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlackenScreen(){
        isBlack = true;
        BlackScreenCanvas.SetActive(true);
        Invoke("DeBlackenScreen", 0.2f);
    }

    public void DeBlackenScreen(){
        isBlack = false;
        BlackScreenCanvas.SetActive(false);
    }
}
