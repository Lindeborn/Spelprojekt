using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(80 * Time.deltaTime, 0, 0 ); //rotates 50 degrees per second around z axis
    }

   
}
