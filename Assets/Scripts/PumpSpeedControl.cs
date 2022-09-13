using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpSpeedControl : MonoBehaviour
{  
    float ns = 0;

    public Text PumpSpeed; //to show result of pump control

    [HideInInspector]
    public static float speedOutput;

    static double p_ele, p1, p2;

    public AudioSource motorSound;

    // public Button pumpBTN;
    public void PumpSpeedControlFunc(string direction)
    {
        if(direction == "UP" && ns<=10)
        {
            if (ns == 10)
            {
                ns = 10;
            }
            else
            {
                ns++;
                transform.Rotate(0, 29f, 0, Space.Self);
            }
        }
        else if (direction == "DOWN" && ns>=0)
        {
            if (ns == 0)
            {
                ns = 0;
            }
            else
            {
                ns--;
                transform.Rotate(0, -29f, 0, Space.Self);
            }
        }

        speedOutput = (ns * 141);
        PumpSpeed.text = speedOutput.ToString(); //show on pump speed screen

        motorSound.volume = ns / 10;  //increase 0.1 per step 

    }
    public void PeleFun()
    {
        p_ele = ((0.0004f * speedOutput * speedOutput) - (0.0902f * speedOutput) + (23.368f));
    }

    public void pressureIncrease1()
    {
        if (!WaterFlow.waterFlowIsOn)
        {
            p1 = -(0.000072) * speedOutput;
        }    
    }

    public void pressureIncrease2()
    {
        p2 = (0.0015) * speedOutput;
    }
}
