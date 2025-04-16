using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROS2;
public class publisher : MonoBehaviour
{
    // Start is called before the first frame update
    private ROS2Node node;
    void Start()
    {   
        node=new ROS2Node("test_node");
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Publisher<std_msgs.msg.String> chatter_pub=node.CreatePublisher<std_msgs.msg.String>("/test_topic/yay");
        // std_msgs.msg.String msg = new std_msgs.msg.String();
        // msg.Data = "yo this fucking workedd";
        // chatter_pub.Publish(msg);   
        // Debug.Log("Publishing");
    }
     public void publishMSG(string message){
        if(node==null){
            node=new ROS2Node("/output/cost");
        }
        Publisher<std_msgs.msg.String> chatter_pub=node.CreatePublisher<std_msgs.msg.String>("/test_topic/yay");
        std_msgs.msg.String msg = new std_msgs.msg.String();
        msg.Data = message;
        chatter_pub.Publish(msg);   
        Debug.Log("Publishing: "+message);
    }
}
