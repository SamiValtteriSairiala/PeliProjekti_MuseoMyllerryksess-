using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public bool MusicIsMuted = false;
    public bool SFXisMuted = false;
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;

    [SerializeField] private Toggle ToggleMusic;
    [SerializeField] private Toggle ToggleSFX;

    private GameObject ToggleMusicParent;
    private GameObject ToggleSfxParent;

    [SerializeField] private AudioSource MusicSource;
    [SerializeField] private AudioSource SFXSource;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainMenu"))
        {
            DontDestroyOnLoad(this.gameObject);
        }
        


    }

    void Awake()
    {

    }



    // Update is called once per frame
    void Update()
    {
        
        //For button usage.
        if (MusicIsMuted == true)
        {
            ToggleMusic.isOn = false;
            MuteMusic();


        }
        if (MusicIsMuted == false && ToggleMusic.isOn == false)
        {
            ToggleMusic.isOn = true;
            UnMuteMusic();
        }
        if (SFXisMuted == true)
        {
            ToggleSFX.isOn = false;
            MuteSFX();
        }
        if (SFXisMuted == false && ToggleSFX.isOn == false)
        {
            ToggleSFX.isOn = true;
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
