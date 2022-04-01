using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PushTheButton : MonoBehaviour
{
    //Add this script to buttons.
    public static event Action<string> ButtonPressed = delegate { };
    private int divaiderPosition;
    private string buttonName, buttonValue;
    // Start is called before the first frame update
    void Start()
    {
        buttonName = gameObject.name;
        divaiderPosition = buttonName.IndexOf("_");
        buttonValue = buttonName.Substring(0, divaiderPosition);
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }


    private void ButtonClicked()
	{
        ButtonPressed(buttonValue);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
