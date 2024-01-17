using System.Collections;
using System.Collections.Generic;
using Unity.Robotics.UrdfImporter;
using UnityEngine;
using UnityEngine.UIElements;

public class MarcusLinkAngleController : MonoBehaviour
{
    
    // Set up all links as variables
    
    public ArticulationBody link_0;
    public ArticulationBody link_1;
    public ArticulationBody link_2;
    public ArticulationBody link_3;
    public ArticulationBody link_4;
    public ArticulationBody link_5;
    public ArticulationBody link_6;

    public GameObject ikSetpoint;

    public float setAngle1 = 0;
    public float setAngle2 = 0;
    public float setAngle3 = 0;
    public float setAngle4 = 0;
    public float setAngle5 = 0;
    public float setAngle6 = 0;

    public bool readFromRos = false;
    public bool useInverseKinematics = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if(readFromRos)
        {
            anglesIn();
        }     
        else   
        {
            anglesOut();
        }
    }

    // Sends angle to command window and ROS2
    private int i = 0;
    void anglesOut()
    {
        i++;
        float angle1 = link_1.transform.localEulerAngles.y;
        float angle2 = link_2.transform.localEulerAngles.x;
        float angle3 = link_3.transform.localEulerAngles.y;
        float angle4 = link_4.transform.localEulerAngles.y;
        float angle5 = link_5.transform.localEulerAngles.x;
        float angle6 = link_6.transform.localEulerAngles.x;
    
        
        if(useInverseKinematics)
        {

        }
        else if(i == 2) // change number opposite of "i" to send coordinates less times per second
        {
            
            Vector3 setpointPosition = ikSetpoint.transform.position;
            

            Debug.Log("Setpoint Position " + setpointPosition);

            i = 0;
        }
    }

    // Takes angle from ROS2 (when set up)
   private int t = 0; 

    void anglesIn()
    {
        
        t++;
        Debug.Log("Changing coordinates manually: x" + t);

        link_1.SetDriveTarget(ArticulationDriveAxis.X, setAngle1);
        link_2.SetDriveTarget(ArticulationDriveAxis.X, setAngle2);
        link_3.SetDriveTarget(ArticulationDriveAxis.X, setAngle3);
        link_4.SetDriveTarget(ArticulationDriveAxis.X, setAngle4);
        link_5.SetDriveTarget(ArticulationDriveAxis.X, setAngle5);
        link_6.SetDriveTarget(ArticulationDriveAxis.X, setAngle6);
        
    }  
    
}
