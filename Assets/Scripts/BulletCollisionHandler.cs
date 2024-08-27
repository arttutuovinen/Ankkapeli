using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the other collider has a tag "Player"
        if (collision.collider.CompareTag("Player2"))
        {
            // Log a message for debugging purposes
            Debug.Log("Bullet collided with Player. Resetting scene...");

            // Reset the current scene by reloading it
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

    
