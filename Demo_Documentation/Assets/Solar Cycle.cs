using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SolarCycle : MonoBehaviour
{
    bool enableDayNightCycle = false;
    float rotationSpeed = -50;
    float tilt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = rotationSpeed * Time.time;
        if (Input.GetKeyDown(KeyCode.E))
        {
            tilt += .5f;
        }

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            enableDayNightCycle = !enableDayNightCycle;
        }

        

        if (enableDayNightCycle == true)
        {
        transform.rotation = Quaternion.Euler(new Vector3(x, tilt, 0));
        }

        if (enableDayNightCycle == true && Input.GetKeyDown(KeyCode.E))
        {
            tilt += .5f;
            transform.rotation = Quaternion.Euler(new Vector3(x, tilt, 0));
        }


    }

    }
