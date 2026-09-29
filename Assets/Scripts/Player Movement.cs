using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f; // Speed of the player movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        if(Keyboard.current.wKey.isPressed)
        {
            input.y += 1;
        }
        if(Keyboard.current.sKey.isPressed)
        {
            input.y -= 1;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            input.x -= 1;
        }
        if(Keyboard.current.dKey.isPressed)
        {
            input.x += 1;
        }
        Vector3 movement = transform.forward * input.y + transform.right * input.x;
        movement.y = 0; // Prevent movement in the y-axis
        if(movement != Vector3.zero)
        {
            movement.Normalize();
            transform.position += movement.normalized * speed * Time.deltaTime;
        }
    }
}
