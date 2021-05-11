using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

   
    void Update()
    {

        
    }

   public void Takedamage(int damage)
    {
        currentHealth -= damage;
        

        healthBar.SetHealth(currentHealth);
        
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
