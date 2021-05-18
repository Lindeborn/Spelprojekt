using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingObstacle : MonoBehaviour
{
    [SerializeField] [Range(0,5)] float speed = 1f;
    [SerializeField] [Range(0,3)] float range = 1f; 

    void Update()
    {
         loop();
    }
 
    void loop()
    {
         float yPos = Mathf.PingPong(Time.time * speed, 10) * range;
         transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
