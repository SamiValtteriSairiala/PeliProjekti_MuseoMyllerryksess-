using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WirePuzzleManager : MonoBehaviour
{
    public GameObject WiresHolder;
    public GameObject[] Wires;
    public int totalWires = 0;
    public int CorrectlyWires = 0;
    [SerializeField] RoomsManager RoomManager;
    [SerializeField] private GameObject ReadyObject;
    [SerializeField] private GameObject NotReadyObject;
    public AudioSource ElectricAudioSource;
    public AudioClip sahkotpaalle;
    public bool AllCorrect = false;
    // Start is called before the first frame update
    void Awake()
    {
        totalWires = WiresHolder.transform.childCount - 1;
        Wires = new GameObject[totalWires];
        for (int i = 0; i < Wires.Length; i++)
        {
            Wires[i] = WiresHolder.transform.GetChild(i).gameObject;
        }
    }

    public void CorrectMove()
    {
        CorrectlyWires += 1;

        if (CorrectlyWires == totalWires)
        {
            ElectricAudioSource.PlayOneShot(sahkotpaalle);
            Debug.Log("Won");
            AllCorrect = true;
            ReadyObject.SetActive(true);
            NotReadyObject.SetActive(false);
            RoomManager.WirePuzzleComplete();
            // Do something.
            // This is win condition.
        }
        if(CorrectlyWires != totalWires){
            ReadyObject.SetActive(false);
            NotReadyObject.SetActive(true);
        }
    }
    public void WrongMove()
    {
        CorrectlyWires -= 1;
        ReadyObject.SetActive(false);
        NotReadyObject.SetActive(true);
        
    }
}
