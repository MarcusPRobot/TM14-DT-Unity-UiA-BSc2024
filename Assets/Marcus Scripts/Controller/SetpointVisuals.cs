using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetpointVisuals : MonoBehaviour
{

    public GameObject radiusCircle;
    public GameObject setpointBall;
    public Transform setpointTracer;

    public float angularSpeed = 1;

    public bool Transparency = true;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setpointBall.transform.position = setpointTracer.position;

        radiusRotation();

        radiusIncreaser();

        heightAdjuster();
        
    }

    void radiusRotation()
    {
        if(Input.GetKey("a"))
        {
            radiusCircle.transform.localEulerAngles = radiusCircle.transform.eulerAngles + new Vector3(0, angularSpeed/2, 0);
        }
        else if(Input.GetKey("d"))
        {
            radiusCircle.transform.localEulerAngles = radiusCircle.transform.eulerAngles - new Vector3(0, angularSpeed/2, 0);
        }
    }

    void heightAdjuster()
    {

        bool tooSmall = false;
        bool tooLarge = false;

        if(radiusCircle.transform.localPosition.y <= -0.2)
        {
            tooSmall = true;
        }
        else if(radiusCircle.transform.localPosition.y >= 1.25)
        {
            tooLarge = true;
        }

        if(Input.GetKey("e") & !tooLarge)
        {
            radiusCircle.transform.position += new Vector3(0, angularSpeed/200, 0);
        }
        else if(Input.GetKey("q") & !tooSmall)
        {
            radiusCircle.transform.position -= new Vector3(0, angularSpeed/200, 0);
        }
    }

    void radiusIncreaser()
    {
        bool tooSmall = false;
        bool tooLarge = false;

        if(radiusCircle.transform.localScale.x <= 0.8)
        {
            tooSmall = true;
        }
        else if(radiusCircle.transform.localScale.x >= 2.5)
        {
            tooLarge = true;
        }

        if(Input.GetKey("w") & !tooLarge)
        {
            radiusCircle.transform.localScale += new Vector3(angularSpeed/200, 0, angularSpeed/200);
        }
        else if(Input.GetKey("s") & !tooSmall)
        {
            radiusCircle.transform.localScale -= new Vector3(angularSpeed/200, 0, angularSpeed/200);
        }
    }

}
