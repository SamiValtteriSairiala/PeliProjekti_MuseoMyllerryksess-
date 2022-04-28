using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class DigitalDisplay : MonoBehaviour
{
    [SerializeField] private Sprite[] digits;
    [SerializeField] private Image[] characters;
    [SerializeField] private GameObject toOfficeArrow;
    [SerializeField] private GameObject clickbox;
    [SerializeField] private GameObject numberlock;
    [SerializeField] private GameObject inventory;
    private string codeSequence;

    public bool DownLock;
    [SerializeField] private string CorrectCode = "714";
    [SerializeField] private string CorrectCodeOutside = "293";
    [SerializeField] private GameObject OfficeScreen;
    [SerializeField] private GameObject FinishScreen;

    public AudioSource KoodiLukko;
    public AudioClip KoodiVaarin;
    // Start is called before the first frame update
    void Start()
    {
        codeSequence = "";
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[0];
        }

        PushTheButton.ButtonPressed += AddDigitToCodeSequence;
    }

    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < 3)
        {
            switch (digitEntered)
            {
                case "Zero":
                    codeSequence += "0";
                    DisplayCodeSequence(0);
                    break;
                case "One":
                    codeSequence += "1";
                    DisplayCodeSequence(1);
                    break;
                case "Two":
                    codeSequence += "2";
                    DisplayCodeSequence(2);
                    break;
                case "Three":
                    codeSequence += "3";
                    DisplayCodeSequence(3);
                    break;
                case "Four":
                    codeSequence += "4";
                    DisplayCodeSequence(4);
                    break;
                case "Five":
                    codeSequence += "5";
                    DisplayCodeSequence(5);
                    break;
                case "Six":
                    codeSequence += "6";
                    DisplayCodeSequence(6);
                    break;
                case "Seven":
                    codeSequence += "7";
                    DisplayCodeSequence(7);
                    break;
                case "Eight":
                    codeSequence += "8";
                    DisplayCodeSequence(8);
                    break;
                case "Nine":
                    codeSequence += "9";
                    DisplayCodeSequence(9);
                    break;
            }
        }
        switch (digitEntered)
        {
            case "Star":
                ResetDisplay();
                break;

            case "Hash":
                if (codeSequence.Length > 0)
                {
                    CheckResults();
                }
                break;
        }
    }

    private void DisplayCodeSequence(int digitJustEntered)
    {
        // This needs to be tested and fixed if it dosent work.
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[digitJustEntered];
                characters[1].sprite = digits[10];
                characters[2].sprite = digits[10];
                break;
            case 2:
                //characters[0].sprite = digits[10];
                characters[1].sprite = digits[digitJustEntered];
                characters[2].sprite = digits[10];
                break;
            case 3:

                characters[2].sprite = digits[digitJustEntered];
                break;
        }
    }

    private void CheckResults()
    {
            // Just checks if there are correct numbers which are specifyed in unity editor.
            //Put correct code here.
            if (codeSequence == CorrectCode && DownLock == true)
            {
                OfficeScreen.SetActive(true);
                numberlock.SetActive(false);
                // Do something.
                Debug.Log("Correct downstairs!");
                toOfficeArrow.SetActive(true);
                clickbox.SetActive(false);
                ResetDisplay();
                DownLock = false;
            }
            else if(codeSequence == CorrectCodeOutside && DownLock ==false){
                FinishScreen.SetActive(true);
                numberlock.SetActive(false);
                Debug.Log("Correct toFinish!");
                inventory.SetActive(false);
            }
        else
        {
            KoodiLukko.PlayOneShot(KoodiVaarin);
            Debug.Log("Wrong");
            ResetDisplay();
        }
    }

    private void ResetDisplay()
    {
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[0];
        }
        codeSequence = "";
    }

    private void OnDestroy()
    {
        PushTheButton.ButtonPressed -= AddDigitToCodeSequence;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
