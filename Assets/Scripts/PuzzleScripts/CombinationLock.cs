using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PuzzleScripts
{


    public class CombinationLock : MonoBehaviour
    {
        [SerializeField] private Text LockText;
        private int FirstNumber = 0;
        private int SecondNumber = 0;
        private int ThirdNumber = 0;
        private int FourthNumber = 0;

        // These are editable from unity to be the right numbers for the lock.
        public int FirstCorrectNumber = 7;
        public int SecondCorrectNumber = 9;
        public int ThirdCorrectNumber = 2;
        public int FourthCorrectNumber = 5;
        // Check if Numbers are correct to check if compination is right.
        private bool FirstNumberIsCorrect;
        private bool SecondNumberIsCorrect;
        private bool ThirdNumberIsCorrect;
        private bool FourthNumberIsCorrect;
        public bool isLocked = true;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (FirstNumber == FirstCorrectNumber)
            {
                FirstNumberIsCorrect = true;
            }
            if (SecondNumber == SecondCorrectNumber)
            {
                SecondNumberIsCorrect = true;
            }
            if (ThirdNumber == ThirdCorrectNumber)
            {
                ThirdNumberIsCorrect = true;
            }
            if (FourthNumber == FourthCorrectNumber)
            {
                FourthNumberIsCorrect = true;
            }
            LockText.text = FirstNumber.ToString("0") + SecondNumber.ToString("0") + ThirdNumber.ToString("0") + FourthNumber.ToString("0");
            // Victory condition.
            if (FirstNumberIsCorrect && SecondNumberIsCorrect && ThirdNumberIsCorrect && FourthNumberIsCorrect)
            {
                isLocked = false;
            }
        }
        public void Lock1ButtonUp()
        {
            FirstNumber += 1;
        }
        public void Lock2ButtonUp()
        {
            SecondNumber += 1;
        }
        public void Lock3ButtonUp()
        {
            ThirdNumber += 1;
        }
        public void Lock4ButtonUp()
        {
            FourthNumber += 1;
        }

        public void LockButton1Down()
        {
            FirstNumber -= 1;
        }
        public void LockButton2Down()
        {
            SecondNumber -= 1;
        }
        public void LockButton3Down()
        {
            ThirdNumber -= 1;
        }
        public void LockButton4Down()
        {
            FourthNumber -= 1;
        }
    }
}
