using UnityEngine;

public class Monsterdamage : MonoBehaviour
{
    public int damage = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHP playerHP = collision.gameObject.GetComponent<PlayerHP>();
            if (playerHP != null)
            {
                playerHP.TakeDamage(damage);
            }
        }
    }   
}
