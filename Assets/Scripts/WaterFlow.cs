using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    float nq = 0;

    [HideInInspector]
    public static double QOutput, p1, p2;

    [HideInInspector]
    public static bool waterFlowIsOn;

    public GameObject water;
    // public Button pumpBTN;


    public void WaterFlowFunc(string direction)
    {
        waterFlowIsOn = true;
        if (direction == "UP" && nq <= 5)
        {
            if (nq == 5)
            {
                nq = 5;
            }
            else
            {
                nq++;
                transform.Rotate(0, 36f, 0, Space.Self);
                water.transform.localScale += new Vector3(0.005f, 0, 0.005f);
            }

        }
        else if (direction == "DOWN" && nq >= 0)
        {
            if (nq == 0)
            {
                nq = 0;
            }
            else
            {
                nq--;
                transform.Rotate(0, -36f, 0, Space.Self);
                water.transform.localScale -= new Vector3(0.005f, 0, 0.005f);
            }       
        }

        if (nq == 0)
        {
            waterFlowIsOn = false;
        }

        QOutput = (0.0435)* PumpSpeedControl.speedOutput* (0.2*nq);

        Debug.Log("g = " + (0.0435) * PumpSpeedControl.speedOutput);
        Debug.Log("h = " + (nq));
        Debug.Log("l = " + (0.2 * nq));

        Debug.Log("QOutput = " + QOutput);
        Debug.Log("nq  = " + nq);
        Debug.Log("speed = " + PumpSpeedControl.speedOutput);
    }

    public void pressureDecrease1()
    {
        p1 = ((-1*10)*QOutput*QOutput) - ((0.0026)*QOutput) - ((0.000072)* PumpSpeedControl.speedOutput);
    }

    public void pressureDecrease2()
    {
        p2 = ((-3 * 10) * QOutput * QOutput) - ((0.0299) * QOutput) + ((0.0015) * PumpSpeedControl.speedOutput);
    }

}
