using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public bool MusicIsMuted = false;
    public bool SFXisMuted = false;
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;
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
        if(SFXisMuted == true){
            MuteSFX();
        }
        if(SFXisMuted == false){
            UnMuteSFX();
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
    public void MuteSFX(){
        SFXMixer.SetFloat("SFXVolume", -80f);
        SFXisMuted = true;
    }
    public void UnMuteSFX(){
        SFXMixer.SetFloat("SFXVolume", 0f);
        SFXisMuted = false;
    }

}
