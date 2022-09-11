using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerOnOff : MonoBehaviour
{
    bool isOn = false;
    public GameObject PumpPower;
    public GameObject PumpSpeed;
    public Button pumpBTN;
    public void PowerOnOffFunc()
    {
        if (!isOn) //open machine
        {
            isOn = true;
            transform.Rotate(0, 180f, 0, Space.Self);
            PumpPower.SetActive(true);
            PumpSpeed.SetActive(true);
            pumpBTN.GetComponent<Button>().interactable = true;
        }
        else if (isOn)  //close machine
        {
            isOn = false;
            transform.Rotate(0, -180f, 0, Space.Self);
            PumpPower.SetActive(false);
            PumpSpeed.SetActive(false);
            pumpBTN.GetComponent<Button>().interactable = false;
        }
    }

}
