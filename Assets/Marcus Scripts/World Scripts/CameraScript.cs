using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] Camera primaryCam;
    [SerializeField] Camera seccondaryCam;
    [SerializeField] Camera thirdCam;
    [SerializeField] Camera fourthCam;

    private int camChoice = 1;

    // Start is called before the first frame update
    void Start()
    {
        primaryCam.enabled = true;
        seccondaryCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("c"))
        {
            camChoice++;

            disableCams();
            changeCam();
        }
    }

    void disableCams()
    {
        primaryCam.enabled = false;
        seccondaryCam.enabled = false;
        thirdCam.enabled = false;
        fourthCam.enabled = false;
    }

    void changeCam()
    {
        if(camChoice == 1)
        {
            primaryCam.enabled = true;
        }
        else if(camChoice == 2)
        {
            seccondaryCam.enabled = true;
        }
        else if(camChoice == 3)
        {
            thirdCam.enabled = true;
        }
        else if(camChoice == 4)
        {
            fourthCam.enabled = true; 

            camChoice = 0;
        }
    }
}
