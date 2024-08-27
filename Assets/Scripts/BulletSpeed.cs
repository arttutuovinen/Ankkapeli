using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float destructionDelay = 2f; // Delay in seconds before the object is destroyed


    void Start()
    {
        rb.velocity = transform.right * speed;

        // Destroy this game object after the specified delay
        Destroy(gameObject, destructionDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
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
