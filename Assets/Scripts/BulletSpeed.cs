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

    // Tag used to identify the ground
    public string groundTag = "Ground";

    // Method called when this object collides with another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object collided with has the ground tag
        if (collision.gameObject.CompareTag(groundTag))
        {
            // Destroy this game object
            Destroy(gameObject);
        }
    }
}
