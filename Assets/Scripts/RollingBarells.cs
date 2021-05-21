using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBarells : MonoBehaviour
{
    private float speed = 0.4f;
    private int direction = 4;

    void Update()
    {
        Vector3 rightPos = new Vector3(9.4777f, transform.position.y, transform.position.z);
        Vector3 leftPos = new Vector3(-23.3f, transform.position.y, transform.position.z);

        if(gameObject.name == "RightBarrel")
        {
            if(transform.position.x > 9.2){
                direction = -4;
            }else if(transform.position.x < -23.0)
            {
                direction = 4;
            }

            transform.position = Vector3.Lerp(rightPos, leftPos, Mathf.PingPong(Time.time*speed, 1.0f));

            transform.Rotate(0, direction, 0*Time.deltaTime);
        
        }

        if(gameObject.name == "LeftBarrel")
        {
            if(transform.position.x > 9.0){
                direction = -4;
            }else if(transform.position.x < -23.0)
            {
                direction = 4;
            }

            transform.position = Vector3.Lerp(leftPos, rightPos, Mathf.PingPong(Time.time*speed, 1.0f));

            transform.Rotate(0, direction, 0*Time.deltaTime);
        }
    }
}
