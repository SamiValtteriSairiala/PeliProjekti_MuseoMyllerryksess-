using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public bool MusicIsMuted = false;
    public bool SFXisMuted = false;
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;

    [SerializeField] private Toggle ToggleMusic;
    [SerializeField] private Toggle ToggleSFX;
    // Start is called before the first frame update
    void Start()
    {

        // DontDestroyOnLoad(this.gameObject);
    }

    void Awake(){

    }



    // Update is called once per frame
    void Update()
    {
        //For button usage.
        if (MusicIsMuted == true)
        {
            MuteMusic();
            
        }
        if (MusicIsMuted == false && ToggleMusic.isOn == false)
        {
            UnMuteMusic();
        }
        if (SFXisMuted == true)
        {
            MuteSFX();
        }
        if (SFXisMuted == false && ToggleSFX.isOn == false)
        {
            UnMuteSFX();
        }
    }

    public void MuteMusic()
    {
        MusicMixer.SetFloat("MusicVolume", -80f);
        MusicIsMuted = true;

        if (MusicIsMuted == true && ToggleMusic.isOn == true)
        {
            MusicMixer.SetFloat("MusicVolume", 0f);
            MusicIsMuted = false;
        }
    }
    public void UnMuteMusic()
    {
        MusicMixer.SetFloat("MusicVolume", 0f);
        MusicIsMuted = false;
    }
    public void MuteSFX()
    {
        SFXMixer.SetFloat("SFXVolume", -80f);
        SFXisMuted = true;
        if (SFXisMuted == true && ToggleSFX.isOn == true)
        {
            SFXMixer.SetFloat("SFXVolume", 0f);
            SFXisMuted = false;
        }
    }
    public void UnMuteSFX()
    {
        SFXMixer.SetFloat("SFXVolume", 0f);
        SFXisMuted = false;
    }

}
