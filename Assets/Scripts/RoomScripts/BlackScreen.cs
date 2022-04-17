using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BlackScreen : MonoBehaviour
{
    public bool isBlack = false;

    [SerializeField] private GameObject BlackScreenCanvas;
    public AudioSource BlackScreenAudioSource;
    public AudioClip Askel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    public void BlackenScreen(){
        isBlack = true;
        BlackScreenCanvas.SetActive(true);
        Invoke("DeBlackenScreen", 0.2f);
    }

    public void DeBlackenScreen(){
        isBlack = false;
        BlackScreenCanvas.SetActive(false);
    }

    public void PlayStep()
	{
        BlackScreenAudioSource.PlayOneShot(Askel);
	}


    
}
