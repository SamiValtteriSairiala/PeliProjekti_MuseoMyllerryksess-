using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PuzzleScripts
{


    public class ElectricPuzzle : MonoBehaviour
    {
        private bool FirstIsCorrect = false;
        private bool SecondIsCorrect = false;
        private bool ThirdIsCorrect = false;
        private bool FourthIsCorrect = false;
        private bool FifthIsCorrect = false;

        private Camera m_Camera;
        // Start is called before the first frame update
        void Start()
        {
            m_Camera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray EP_Ray = m_Camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D EP_hit = Physics2D.Raycast(EP_Ray.origin, EP_Ray.direction);
                if (EP_hit)
                {
                    Debug.Log(EP_hit.transform.name);
                    if (EP_hit.collider != null)
                    {
                        // add some values to x, y, z
                        EP_hit.transform.Rotate(2f, 0f, 0f);
                    }
                }
            }
            
            if (FirstIsCorrect == true && SecondIsCorrect == true && ThirdIsCorrect == true && FourthIsCorrect == true && FifthIsCorrect == true)
            {
                // Victory screen here.
            }
        }
    }
}
