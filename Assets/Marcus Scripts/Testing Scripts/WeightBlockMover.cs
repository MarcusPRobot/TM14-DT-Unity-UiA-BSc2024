using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightBlockMover : MonoBehaviour
{
    public Transform weightCube;
    private Vector3 setPoint= new Vector3(0, 3, 0);


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            weightCube.position = setPoint;
        }
    }
}
