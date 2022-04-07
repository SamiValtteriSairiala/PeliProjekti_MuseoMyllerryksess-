using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManagerMuseum : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;
    public bool MusicIsMutedMuseum = false;
    public bool SFXisMuted = false;
    [SerializeField] private Toggle ToggleMusic;
    [SerializeField] private Toggle ToggleSFX;

    private SoundManager SoundManager;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager = FindObjectOfType<SoundManager>();
        if (SoundManager.MusicIsMuted == true)
        {
            ToggleMusic.isOn = false;
            SoundManager.MusicIsMuted = true;
            MuteMusic();


        }
        if (SoundManager.MusicIsMuted == false && ToggleMusic.isOn == false)
        {
            ToggleMusic.isOn = true;
            SoundManager.MusicIsMuted = false;
            UnMuteMusic();
        }
        if (SoundManager.SFXisMuted == true)
        {
            ToggleSFX.isOn = false;
            SoundManager.SFXisMuted = true;
            MuteSFX();
        }
        if (SoundManager.SFXisMuted == false && ToggleSFX.isOn == false)
        {
            ToggleSFX.isOn = true;
            SoundManager.SFXisMuted = false;
            UnMuteSFX();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MuteMusic()
    {
        MusicMixer.SetFloat("MusicVolume", -80f);
        MusicIsMutedMuseum = true;
        SoundManager.MusicIsMuted = true;

        if (MusicIsMutedMuseum == true && ToggleMusic.isOn == true)
        {
            SoundManager.MusicIsMuted = false;
            MusicMixer.SetFloat("MusicVolume", 0f);
            MusicIsMutedMuseum = false;
        }
    }
    public void UnMuteMusic()
    {
        MusicMixer.SetFloat("MusicVolume", 0f);
        MusicIsMutedMuseum = false;
        SoundManager.MusicIsMuted = false;
        
    }
    public void MuteSFX()
    {
        SFXMixer.SetFloat("SFXVolume", -80f);
        SFXisMuted = true;
        SoundManager.SFXisMuted = true;
        if (SFXisMuted == true && ToggleSFX.isOn == true)
        {
            SoundManager.SFXisMuted = false;
            SFXMixer.SetFloat("SFXVolume", 0f);
            SFXisMuted = false;
        }
    }
    public void UnMuteSFX()
    {
        SFXMixer.SetFloat("SFXVolume", 0f);
        SFXisMuted = false;
        SoundManager.SFXisMuted = false;
    }
}
