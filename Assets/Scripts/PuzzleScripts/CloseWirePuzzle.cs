using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWirePuzzle : MonoBehaviour
{
    [SerializeField] private GameObject Wires;
    [SerializeField] private GameObject ElectricBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown(){
        Wires.SetActive(false);
        ElectricBox.SetActive(true);
    }
}
