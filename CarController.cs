using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    ////////    public WheelCollider WheelFL;
    ////////    public WheelCollider WheelFR;
    ////////    public WheelCollider WheelRL;
    ////////    public WheelCollider WheelRR;
    ////////    public Transform WheelFLtrans;
    ////////    public Transform WheelFRtrans;
    ////////    public Transform WheelRLtrans;
    ////////    public Transform WheelRRtrans;
    ////////    public Vector3 eulertest;
    ////////    float maxFwdSpeed = -3000;
    ////////    float maxBwdSpeed = 1000f;
    ////////    float gravity = 9.8f;
    ////////    private bool braked = false;
    ////////    private float maxBrakeTorque = 500;
    ////////    private Rigidbody rb;
    ////////    public Transform centreofmass;
    ////////    private float maxTorque = 1000;
    ////////    void Start()
    ////////    {
    ////////        rb = GetComponent<Rigidbody>();
    ////////        rb.centerOfMass = centreofmass.transform.localPosition;
    ////////    }

    ////////    void FixedUpdate()
    ////////    {
    ////////        if (!braked)
    ////////        {
    ////////            WheelFL.brakeTorque = 0;
    ////////            WheelFR.brakeTorque = 0;
    ////////            WheelRL.brakeTorque = 0;
    ////////            WheelRR.brakeTorque = 0;
    ////////        }
    ////////        //speed of car, Car will move as you will provide the input to it.

    ////////        WheelRR.motorTorque = maxTorque * Input.GetAxis("Vertical");
    ////////        WheelRL.motorTorque = maxTorque * Input.GetAxis("Vertical");

    ////////        //changing car direction
    ////////        /// Here we are changing the steer angle of the front tyres of the car so that we can change the car direction.
    ////////        WheelFL.steerAngle = 30 * (Input.GetAxis("Horizontal"));
    ////////        WheelFR.steerAngle = 30 * Input.GetAxis("Horizontal");
    ////////    }
    ////////    void Update()
    ////////    {
    ////////        HandBrake();

    ////////        //for tyre rotate
    ////////        WheelFLtrans.Rotate(WheelFL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    ////////        WheelFRtrans.Rotate(WheelFR.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    ////////        WheelRLtrans.Rotate(WheelRL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    ////////        WheelRRtrans.Rotate(WheelRL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    ////////        //changing tyre direction
    ////////        Vector3 temp = WheelFLtrans.localEulerAngles;
    ////////        Vector3 temp1 = WheelFRtrans.localEulerAngles;
    ////////        temp.y = WheelFL.steerAngle - (WheelFLtrans.localEulerAngles.z);
    ////////        WheelFLtrans.localEulerAngles = temp;
    ////////        temp1.y = WheelFR.steerAngle - WheelFRtrans.localEulerAngles.z;
    ////////        WheelFRtrans.localEulerAngles = temp1;
    ////////        eulertest = WheelFLtrans.localEulerAngles;
    ////////    }
    ////////    void HandBrake()
    ////////    {
    ////////        //Debug.Log("brakes " + braked);
    ////////        if (Input.GetButton("Jump"))
    ////////        {
    ////////            braked = true;
    ////////        }
    ////////        else
    ////////        {
    ////////            braked = false;
    ////////        }
    ////////        if (braked)
    ////////        {

    ////////            WheelRL.brakeTorque = maxBrakeTorque * 20;//0000;
    ////////            WheelRR.brakeTorque = maxBrakeTorque * 20;//0000;
    ////////            WheelRL.motorTorque = 0;
    ////////            WheelRR.motorTorque = 0;
    ////////        }
    ////////    }
    ////////}
    ///































    ///Ovde
    //public float enginePower = 100.0f;
    //public float power = 0.0f;
    //public float brake = 533.0f;
    //public float steer = 0.0f;
    //public float maxSteer = 25.0f;
    //public WheelCollider Wheel_LF;
    //public WheelCollider Wheel_RF;
    //public WheelCollider Wheel_LR;
    //public WheelCollider Wheel_RR;


    //void Start()
    //{
    //    GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, -0.5f, 0.5f);
    //}

    //void Update()
    //{

    //    power = Input.GetAxis("Vertical") * enginePower * Time.deltaTime * 10.0f;
    //    steer = Input.GetAxis("Horizontal") * maxSteer;
    //    brake = Input.GetKey("space") ? GetComponent<Rigidbody>().mass * 33333.0f : 0.0f;

    //    Wheel_LF.steerAngle = steer;
    //    Wheel_RF.steerAngle = steer;

    //    // enginePower = Mathf.Clamp(enginePower, 0f, 30f);



    //    if (brake > 0.0)
    //    {
    //        Wheel_LF.brakeTorque = brake;
    //        Wheel_RF.brakeTorque = brake;
    //        Wheel_LR.brakeTorque = brake;
    //        Wheel_RR.brakeTorque = brake;
    //        Wheel_LR.motorTorque = 0.0f;
    //        Wheel_RR.motorTorque = 0.0f;
    //    }
    //    else
    //    {
    //        Wheel_LF.brakeTorque = 0;
    //        Wheel_RF.brakeTorque = 0;
    //        Wheel_LR.brakeTorque = 0;
    //        Wheel_RR.brakeTorque = 0;
    //        Wheel_LR.motorTorque = power;
    //        Wheel_RR.motorTorque = power;
    //    }
    //}
    ///Ovde



    public float enginePower = 100.0f;
    public float power = 0.0f;
    public float brake = 533.0f;
    public float steer = 0.0f;
    public float maxSteer = 25.0f;
    public WheelCollider Wheel_LF;
    public WheelCollider Wheel_RF;
    public WheelCollider Wheel_LR;
    public WheelCollider Wheel_RR;


    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, -0.5f, 0.5f);
    }



    



    void Update()
    {

        power = Input.GetAxis("Vertical") * enginePower * Time.deltaTime * 10.0f;
        steer = Input.GetAxis("Horizontal") * maxSteer;
        brake = Input.GetKey("space") ? GetComponent<Rigidbody>().mass * 33333.0f : 0.0f;

        Wheel_LF.steerAngle = steer;
        Wheel_RF.steerAngle = steer;

        // enginePower = Mathf.Clamp(enginePower, 0f, 30f);



        if (brake > 0.0)
        {
            Wheel_LF.brakeTorque = brake;
            Wheel_RF.brakeTorque = brake;
            Wheel_LR.brakeTorque = brake;
            Wheel_RR.brakeTorque = brake;
            Wheel_LR.motorTorque = 0.0f;
            Wheel_RR.motorTorque = 0.0f;
        }
        else
        {
            Wheel_LF.brakeTorque = 0;
            Wheel_RF.brakeTorque = 0;
            Wheel_LR.brakeTorque = 0;
            Wheel_RR.brakeTorque = 0;
            Wheel_LR.motorTorque = power;
            Wheel_RR.motorTorque = power;
        }
    }
}
