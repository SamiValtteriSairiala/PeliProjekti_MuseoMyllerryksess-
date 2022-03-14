using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PuzzleScript
{

    public class TileScript : MonoBehaviour
    {
        public Vector3 TargetPos;
        private Vector3 correctPos;
        public int number;
        public bool inRightPlace;

        // Start is called before the first frame update
        void Awake()
        {
            TargetPos = transform.position;
            correctPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, TargetPos, 0.05f);
            if (TargetPos == correctPos)
            {
                inRightPlace = true;
            }
            else
            {
                inRightPlace = false;
            }
        }
    }
}