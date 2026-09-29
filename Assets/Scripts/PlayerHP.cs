using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
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
}
