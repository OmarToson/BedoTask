using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpOnOff : MonoBehaviour
{
    bool isOn = false;

    public void PumpOnOffFunc()
    {
        if (!isOn) //open machine
        {
            isOn = true;
            transform.Rotate(0, 90f, 0, Space.Self);
        }
        else if (isOn)  //close machine
        {
            isOn = false;
            transform.Rotate(0, -90f, 0, Space.Self);
        }
    }

}
