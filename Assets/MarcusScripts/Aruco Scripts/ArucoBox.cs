using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArucoBox : MonoBehaviour
{
    public GameObject arucoBoxInspector;
    public GameObject arucoTracerBoxInspector;
    public static GameObject arucoBox;
    private bool notDetected = true;
    private MeshRenderer arucoRenderer;


    [HideInInspector] public static Vector3 coordinates;
    [HideInInspector] public static bool coordinatesChanged = false;
    [HideInInspector] public static float yRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        arucoBox = arucoBoxInspector;
        arucoRenderer = arucoBox.GetComponent<MeshRenderer>();
        arucoRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(notDetected && coordinatesChanged)
        {
            arucoRenderer.enabled = true;
            arucoRenderer = null;
            notDetected = false;
        }  

        if(coordinatesChanged)
        {
            arucoBox.transform.localPosition = new Vector3(-coordinates.x, arucoBox.transform.localPosition.y, coordinates.z);
            arucoBox.transform.localEulerAngles = new Vector3(0, yRotation, 0);

            AutoPickup.boxLastPosition = arucoBox.transform.localPosition;
            arucoTracerBoxInspector.transform.position = arucoBox.transform.position;
            coordinatesChanged = false;
        }

        //print(arucoBox.transform.localPosition.x);

    }
}
