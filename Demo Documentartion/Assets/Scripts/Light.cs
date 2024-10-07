using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class FlashlightTool : MonoBehaviour
{
    private float batteryEmpty = 0;
    private float batteryMaximum = 100;
    private float batteryCharge = 100;
    private float timeForBatteryToDrain = 0.001f;
    private float batteryHasBeenRunningFor;
    private Light Flashlight;
    private Light Sun;
    bool flashlightState = false;

    // Start is called before the first frame update

    void Start()
    {
       GameObject lightGameObject = new GameObject("The Light");

        Flashlight = lightGameObject.AddComponent<Light>();
        
        Flashlight.color = Color.white;

        Flashlight.type = LightType.Point;

        lightGameObject.transform.position = new Vector3(0, 2, -5);

        flashlightState = true;
    }

    // Update is called once per frame
    void Update()
    {
        batteryHasBeenRunningFor += Time.deltaTime;
        float percentageComplete = batteryHasBeenRunningFor / timeForBatteryToDrain;

         batteryMaximum = Mathf.Lerp(batteryMaximum, batteryEmpty, percentageComplete);

        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlightState = !flashlightState;
        }

        if (flashlightState == false)
            batteryCharge = Mathf.Lerp(batteryCharge, 10, timeForBatteryToDrain);
            Flashlight.intensity = batteryCharge;
        {
            Flashlight.intensity = batteryCharge;
        }


        if (flashlightState == true && batteryCharge > 0)
        {
            batteryCharge = Mathf.Lerp(batteryCharge, 0, timeForBatteryToDrain);
            Flashlight.intensity = batteryCharge;
        }
     

    }
}