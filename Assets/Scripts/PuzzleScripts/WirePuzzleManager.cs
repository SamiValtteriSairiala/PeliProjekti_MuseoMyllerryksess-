using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePuzzleManager : MonoBehaviour
{
    public GameObject WiresHolder;
    public GameObject[] Wires;
    public int totalWires = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalWires = WiresHolder.transform.childCount;
        Wires = new GameObject[totalWires];
        for (int i = 0; i < Wires.Length; i++)
        {
            Wires[i] = WiresHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
