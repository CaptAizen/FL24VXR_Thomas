using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();

        myLight.range = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        myLight.range = Mathf.PingPong(Time.time * 5, 10) + 5;
    }
}
