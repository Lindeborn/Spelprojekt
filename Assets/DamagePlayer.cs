using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public PlayerHealth playerHealth;
    int damage = 10;
    int health = 15;

    public bool beInFire;
    public bool stopDealDamage;
   

    private void Start()
    {

    }






    private void Update()
    {
        if (beInFire == true)
        {
            if (stopDealDamage == false)
            {
                stopDealDamage = true;
                StartCoroutine(DamageFromFire());

            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            playerHealth.Takedamage(damage);
        }
        

    }

    private void OnTriggerEnter(Collider col)
    {


       


        if (col.tag == "fire")
        {
            beInFire = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "fire")
        {
            beInFire = false;
        }
    }

    IEnumerator DamageFromFire()
    {
        yield return new WaitForSeconds(1);
        playerHealth.Takedamage(damage);
        stopDealDamage = false;
    }























    /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            print("enemy just touched something wierd");
             playerHealth.Takedamage(damage);
            Invoke("DmgOverTime", 2);
        }

        


    }

    void DmgOverTime()
    {
       
            playerHealth.Takedamage(damage);

    }

  */


}