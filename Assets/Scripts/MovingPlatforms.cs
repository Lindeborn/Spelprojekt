using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public float speed = 0.3f;

    void Update() 
    {
        loop();
    }

    void loop()
    {
        Vector3 posOut = new Vector3(transform.position.x, transform.position.y, 78.7f);
        Vector3 posIn = new Vector3(transform.position.x, transform.position.y, 85.45f);
        
        if(gameObject.name == "PlatformOut")
        {
            transform.position = Vector3.Lerp(posOut, posIn, Mathf.PingPong(Time.time*speed, 1.0f));
        }
        else if(gameObject.name == "PlatformIn")
        {
            transform.position = Vector3.Lerp(posIn, posOut, Mathf.PingPong(Time.time*speed, 1.0f));
        }
    }
}
