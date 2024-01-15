using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public WheelCollider solonteker, sagonteker, solarkateker, sagarkateker;
    public float motorhizi,donmehizi;
    public Joystick tus;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        sagarkateker.motorTorque = motorhizi * tus.Vertical;
        solarkateker.motorTorque = motorhizi * tus.Vertical;
        solonteker.steerAngle = donmehizi * tus.Horizontal;
        sagonteker.steerAngle = donmehizi * tus.Horizontal;

        
    }
}

