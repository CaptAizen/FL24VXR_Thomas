using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanelSlide : MonoBehaviour
{
    public float speed = -2f;
    public float distance = 7f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3 (x, transform.position.y, transform.position.z);

    }
}
