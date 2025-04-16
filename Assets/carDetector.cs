using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carDetector : MonoBehaviour
{
    public float speedThreshold = 15.0f; // Speed threshold to detect the car
    public float JerkThreshold = 2.0f; // Jerk threshold to detect the car
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    private float prevVelocity=0.0f;
    private float prevAcceleration=0.0f;

    public publisher pub;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Time.time % 2 < 0.01f && rigidbody.velocity.magnitude > speedThreshold) {
            pub.GetComponent<publisher>().publishMSG("OVS");
        }
        float Jerk=((rigidbody.velocity.magnitude - prevVelocity)-prevAcceleration) / Time.deltaTime * 0.01f;
        if(Jerk>JerkThreshold) {
            pub.GetComponent<publisher>().publishMSG("JRK");
        }
        prevAcceleration= (rigidbody.velocity.magnitude - prevVelocity) / Time.deltaTime;
        prevVelocity = rigidbody.velocity.magnitude;
    }
}
