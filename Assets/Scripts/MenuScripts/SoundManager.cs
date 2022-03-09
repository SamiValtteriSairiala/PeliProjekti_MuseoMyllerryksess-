using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public bool MusicIsMuted = false;
    public AudioMixer MusicMixer;
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(this.gameObject);
    }

    

    // Update is called once per frame
    void Update()
    {
        if(MusicIsMuted == true){
            MuteMusic();
        }
        if(MusicIsMuted == false){
            UnMuteMusic();
        }
    }

    public void MuteMusic(){
        MusicMixer.SetFloat("MusicVolume", -80f);
        MusicIsMuted = true;
    }
    public void UnMuteMusic(){
        MusicMixer.SetFloat("MusicVolume", 0f);
        MusicIsMuted = false;
    }

}
