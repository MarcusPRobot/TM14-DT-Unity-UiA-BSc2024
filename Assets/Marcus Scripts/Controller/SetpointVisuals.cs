using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetpointVisuals : MonoBehaviour
{

    public GameObject radiusCircle;
    public GameObject setpointBall;
    public Transform setpointTracer;
    public SetpointSaver saver;

    private float angularSpeed = 65;

    public bool Transparency = true;

    private bool circularMovement = true;

    void Update()
    {
        // Sets the position of the ball to the desired position
        if(circularMovement)
        {
            setpointBall.transform.position = setpointTracer.position;
        }

        checkInput();
    }


    void radiusRotation()
    {
        if(!circularMovement)
        {
            if (Input.GetKey("w"))
            {
                setpointBall.transform.localPosition += new Vector3(Time.deltaTime * angularSpeed / 400, 0, 0);
            }
            else if (Input.GetKey("s"))
            {
                setpointBall.transform.localPosition -= new Vector3(Time.deltaTime * angularSpeed / 400, 0, 0);
            }
        }
        else
        {
            if(Input.GetKey("a"))
            {
                radiusCircle.transform.localEulerAngles += new Vector3(0, Time.deltaTime * angularSpeed/2, 0);
            }
            else if(Input.GetKey("d"))
            {
                radiusCircle.transform.localEulerAngles -= new Vector3(0, Time.deltaTime * angularSpeed/2, 0);
            }
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

        if(circularMovement)
        {
            if(Input.GetKey("e") & !tooLarge)
            {
                radiusCircle.transform.position += new Vector3(0, Time.deltaTime * angularSpeed/200, 0);
            }
            else if(Input.GetKey("q") & !tooSmall)
            {
                radiusCircle.transform.position -= new Vector3(0, Time.deltaTime * angularSpeed/200, 0);
            }
        }
        else
        {
            if (Input.GetKey("e") & !tooLarge)
            {
                setpointBall.transform.localPosition += new Vector3(0, Time.deltaTime * angularSpeed / 400, 0);
            }
            else if (Input.GetKey("q") & !tooSmall)
            {
                setpointBall.transform.localPosition -= new Vector3(0, Time.deltaTime * angularSpeed / 400, 0);
            }
        }
        
    }

    void toggleLoop()
    {
        if (Input.GetKeyDown("l"))
        {
            UDP_Client.loopMode = !UDP_Client.loopMode;
            print("Loop mode: " + UDP_Client.loopMode);
        }
    }

    void radiusIncreaser()
    {

        bool tooSmall = false;
        bool tooLarge = false;

        
        if(radiusCircle.transform.localScale.x <= 0.5)
        {
            tooSmall = true;
        }
        else if(radiusCircle.transform.localScale.x >= 2.5)
        {
            tooLarge = true;
        }

        if(circularMovement)
        {
            if(Input.GetKey("w") & !tooLarge)
            {
                radiusCircle.transform.localScale += new Vector3(Time.deltaTime * angularSpeed/200, 0, Time.deltaTime * angularSpeed/200);
            }
            else if(Input.GetKey("s") & !tooSmall)
            {
                radiusCircle.transform.localScale -= new Vector3(Time.deltaTime * angularSpeed/200, 0, Time.deltaTime * angularSpeed/200);
            } 
        }
        else
        {
            if (Input.GetKey("a") & !tooLarge)
            {
                setpointBall.transform.localPosition += new Vector3(0, 0, Time.deltaTime * angularSpeed / 400);
            }
            else if (Input.GetKey("d") & !tooSmall)
            {
                setpointBall.transform.localPosition -= new Vector3(0, 0, Time.deltaTime * angularSpeed / 400);
            }
        }

    }

    void coordinateSaver()
    {
        if(Input.GetKeyDown("f"))
        {
            saver.saveCoordinates();
        }
        else if(Input.GetKeyDown("r"))
        {
            saver.resetList();
        }
        else if(Input.GetKeyDown("p"))
        {
            saver.pushAllCoordinates();
        }
        else if(Input.GetKeyDown("g"))
        {
            saver.saveCoordinatesGripped();
        }
    }

    void ballRotater()
    {
        if (Input.GetKey("k"))
        {
            setpointBall.transform.eulerAngles += new Vector3(0, Time.deltaTime * angularSpeed / 2, 0);
        }
        else if (Input.GetKey("h"))
        {
            setpointBall.transform.eulerAngles -= new Vector3(0, Time.deltaTime * angularSpeed / 2, 0);
        }

        if (Input.GetKey("y"))
        {
            setpointBall.transform.eulerAngles += new Vector3(Time.deltaTime * angularSpeed / 2, 0, 0);
        }
        else if (Input.GetKey("i"))
        {
            setpointBall.transform.eulerAngles -= new Vector3(Time.deltaTime * angularSpeed / 2, 0, 0);
        }

        if (Input.GetKey("u"))
        {
            setpointBall.transform.eulerAngles += new Vector3(0, 0, Time.deltaTime * angularSpeed / 2);
        }
        else if (Input.GetKey("j"))
        {
            setpointBall.transform.eulerAngles -= new Vector3(0, 0, Time.deltaTime * angularSpeed / 2);
        }

        if (Input.GetKey("o"))
        {
            setpointBall.transform.eulerAngles = new Vector3(0, -90, 0);
        }

        if(Input.GetKey("9"))
        {
            setpointBall.transform.eulerAngles = new Vector3(0, -90, -90);
        }

    }

    void toggleVisuals()
    {
        if (Input.GetKeyDown("t"))
        {
            if (Transparency)
            {
                setpointBall.GetComponent<MeshRenderer>().enabled = false;
                Renderer[] childRenderers = setpointBall.GetComponentsInChildren<Renderer>();
                foreach (Renderer renderer in childRenderers)
                {
                    renderer.enabled = false;
                }
                

                radiusCircle.GetComponent<MeshRenderer>().enabled = false;
                Transparency = false;
            }
            else
            {
                setpointBall.GetComponent<MeshRenderer>().enabled = true;
                Renderer[] childRenderers = setpointBall.GetComponentsInChildren<Renderer>();
                foreach (Renderer renderer in childRenderers)
                {
                    renderer.enabled = true;
                }
                radiusCircle.GetComponent<MeshRenderer>().enabled = true;
                Transparency = true;
            }
        }
    }

    void movementChanger()
    {
        if (Input.GetKeyDown("x"))
        {
            if (circularMovement)
            {
                circularMovement = false;
            }
            else
            {
                circularMovement = true;
            }
        }
    }

    void programShutdown()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

    void checkInput()
    {
        movementChanger();
        radiusRotation();
        radiusIncreaser();
        heightAdjuster();
        coordinateSaver();
        ballRotater();
        toggleVisuals();
        toggleLoop();
        programShutdown();
    }
}


