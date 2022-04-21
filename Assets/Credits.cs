using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject SoundManager;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        Destroy(SoundManager);
        SceneManager.LoadScene("MainMenu");
    }

    public void CreditsOpen()
    {
        Destroy(SoundManager);
        SceneManager.LoadScene("Credits");
    }

}
