using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for the monster to follow
    public float speed = 2f; // Speed of the monster
    private int currentPoint = 0; // Index of the current waypoint the monster is moving towards

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        if (waypoints.Length == 0) return;
        Transform target = waypoints[currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, target.position) < 0.1f)
        {
             currentPoint++;
            if(currentPoint >= waypoints.Length)
            {
                currentPoint = 0;
            }
        }
    }
}
