using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelMeter : MonoBehaviour
{
    public static FuelMeter fm = null;

    void OnEnable()
    {
        FuelMeter.fm = this;
    }

    private float fuelValue = 100;

    private float globalSpeed = 2f;

    public Text fuelMeterText;

    void DecrementFuelValue()
    {
        fuelValue -= Time.deltaTime * globalSpeed;
    }

    void FixedUpdate()
    {
        DecrementFuelValue();
        fuelMeterText.text = fuelValue.ToString();
    }

    public void IncrementFuel()
    {
        if(fuelValue > 85)
        {
            fuelValue = 100;
        }
        else
        {
            fuelValue += 15;
        }
    }

}
