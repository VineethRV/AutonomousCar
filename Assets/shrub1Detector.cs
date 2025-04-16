using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{
    public publisher pub;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Collision Detector Initialized");   
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Collision Detector Initialized");
    }
    void OnCollisionEnter(Collision collision){
        pub.GetComponent<publisher>().publishMSG("SRB");
    }
}
