using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeMove : MonoBehaviour
{
    [SerializeField] private GameObject OfficeScreen;
    [SerializeField] private GameObject DownStairs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void MoveBackToDownstairs()
    {
        OfficeScreen.SetActive(false);
        DownStairs.SetActive(true);
    }
}
