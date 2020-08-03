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

    public float fuelValue = 100;

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

}
