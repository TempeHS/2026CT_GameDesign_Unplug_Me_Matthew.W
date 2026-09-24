using UnityEngine;

public class EnemyFollow: MonoBehaviour
{
    public Transform player; // drag and drop player onto this
    public float speed = 5f;

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);          
        }   
    }
}
