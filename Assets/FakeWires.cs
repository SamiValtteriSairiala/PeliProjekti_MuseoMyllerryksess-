using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWires : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270};
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
    }

    private void OnMouseDown()
    {
        // isRotating = true;
        transform.Rotate(new Vector3(0, 0, 90f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
