using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPathPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject PathPuzzle;
    [SerializeField] private GameObject Downstairs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        Downstairs.SetActive(false);
        PathPuzzle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
