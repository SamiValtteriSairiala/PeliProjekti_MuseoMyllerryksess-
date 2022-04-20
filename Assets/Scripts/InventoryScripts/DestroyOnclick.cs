using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnclick : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject toDestroy;
    [SerializeField] private GameObject toDeActivate;
    
    [SerializeField] private GameObject toActivate;
    [SerializeField] private GameObject toActivate2;

    [SerializeField] private GameObject checkIfDestroyed1;
    [SerializeField] private GameObject checkIfDestroyed2;
    [SerializeField] private GameObject checkIfDestroyed3;
    [SerializeField] private GameObject toFinish;
    [SerializeField] private GameObject note;


    public void Interact()
    {
        Destroy(toDestroy);
        toDeActivate.SetActive(false);
        toActivate.SetActive(true);
        toActivate2.SetActive(true);

        if(checkIfDestroyed1 == null && checkIfDestroyed2 == null && checkIfDestroyed3 == null){
            toFinish.SetActive(true);
        }
        if(gameObject.name == "girlll"){
            note.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
