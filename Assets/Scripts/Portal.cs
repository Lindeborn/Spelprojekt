using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    // Update is called once per frame
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            Application.LoadLevel("level02");
        } 
    }
}
