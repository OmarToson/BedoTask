using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowMeter : MonoBehaviour
{
    bool isOn = false;
    double v;

    double zScale;
    public GameObject flowMeter;

    public void FlowMeterFunc()
    {
        if (!isOn) //open machine
        {
            isOn = true;
            transform.Rotate(0, 90f, 0, Space.Self);
            VperSecond();
                zScale = v * 0.25f;
            double qqq = v;
            while (v<60)
            {
                qqq += v;
                flowMeter.transform.localScale += new Vector3(0, 0, (float)zScale);
            }
        }
        else if (isOn)  //close machine
        {
            isOn = false;
            transform.Rotate(0, -90f, 0, Space.Self);
        }
    }

    public void VperSecond()
    {
        v = WaterFlow.QOutput / 60;
        Debug.Log("v = " + v);
    }
}
