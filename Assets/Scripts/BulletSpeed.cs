using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public Rigidbody2D rb;
    public float destructionDelay = 2f; // Delay in seconds before the object is destroyed
    public float bulletSpeed = 50f;
    

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
        // Destroy this game object after the specified delay
        Destroy(gameObject, destructionDelay);
    }

    

    // Method called when this object collides with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            // Destroy this game object
            Destroy(gameObject);
            ScoreManager.instance.AddPointP1();
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy this game object
            Destroy(gameObject);
            ScoreManager.instance.AddPointP2();
        }

        else
        {
            Destroy(gameObject);
        }
    }

 
}
