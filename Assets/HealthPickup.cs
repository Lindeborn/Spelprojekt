using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;
    public HealthBar healthBar;
    public int healthbonus = 15;

    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthbonus;
            healthBar.SetHealth(playerHealth.currentHealth);
        }
    }
}
