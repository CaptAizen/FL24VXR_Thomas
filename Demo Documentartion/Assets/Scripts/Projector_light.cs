using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;


public class Projector_light : MonoBehaviour
{
    float x = 1;
    float y = 1;
    float cookieSizeIncrement = 1f;
    float cookieSizeMax = 10f;

    // Start is called before the first frame update
    void Start()
    { }
    [SerializeField] private Vector2 m_lightCookieSize = new Vector2(0, 0);
    public Vector2 CookieSize
    {

        get => m_lightCookieSize;
        set
        {
            m_lightCookieSize = value;
            GetComponent<UniversalAdditionalLightData>().lightCookieSize = value;
        }

    }

    // Update is called once per frame
    void Update()
    {

        float x = Mathf.PingPong(Time.time * cookieSizeIncrement, cookieSizeMax);
        float y = Mathf.PingPong(Time.time * cookieSizeIncrement, cookieSizeMax);
        CookieSize = new Vector2(x, y);


    }
}