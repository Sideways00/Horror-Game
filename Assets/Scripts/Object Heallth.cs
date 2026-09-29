using UnityEngine;

public class ObjectHeallth : MonoBehaviour
{
    public int maxhealth = 100;
    public int currentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxhealth;
    }

    // Update is called once per frame
    public void Shatter(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Current Health: " + currentHealth);
        if(currentHealth <= 0)
        {
            Debug.Log("Object destroyed");
            Destroy(gameObject);
        }
    }
}
