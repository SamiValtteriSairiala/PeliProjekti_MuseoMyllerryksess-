using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePuzzleManager : MonoBehaviour
{
    public GameObject WiresHolder;
    public GameObject[] Wires;
    public int totalWires = 0;
    public int CorrectlyWires = 0;
    [SerializeField] RoomsManager RoomManager;
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
            Debug.Log("Won");
            RoomManager.WirePuzzleComplete();
            // Do something.
            // This is win condition.
        }
    }
    public void WrongMove()
    {
        CorrectlyWires -= 1;
    }
}
