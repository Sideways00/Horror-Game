using UnityEngine;

public class PunchDamage : MonoBehaviour
{
    public int damage = 15; // The amount of damage the punch does
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OntriggerEnter(Collider other)
    {
        // Check if the object we collided with has the "Enemy" tag
        if (other.CompareTag("Object"))
        {
            // Get the EnemyHealth component from the enemy object
            ObjectHeallth objectHeallth = other.GetComponent<ObjectHeallth>();
            // If the enemy has an EnemyHealth component, apply damage
            if (objectHeallth != null)
            {
                objectHeallth.Shatter(damage);
            }
        }
    }
}
