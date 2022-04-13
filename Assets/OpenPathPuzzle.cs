using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPathPuzzle : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject PathPuzzle;
    [SerializeField] private GameObject Downstairs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Interact(){
        Downstairs.SetActive(false);
        PathPuzzle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
