using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public Image healthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Player has died.");
        // Add death logic here (e.g., respawn, game over screen, etc.)
    }
    void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(currentHealth / maxHealth, 0, 1  );
    }
}
