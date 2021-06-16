using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    private Vector3 originalPosition;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

   
    void Update()
    {
        
    }

   public void Takedamage(int damage)
    {
        currentHealth -= damage;
        

        healthBar.SetHealth(currentHealth);

        if(currentHealth == 0){
            gameObject.transform.position = originalPosition;
            Start();
        }
        
    }

    public void Gainhealth(int health)
    {
        currentHealth -= health;

        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamageOverTime(int damage)
    {

    }
}
