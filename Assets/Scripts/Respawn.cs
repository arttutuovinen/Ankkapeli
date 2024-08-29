using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPointPlayer1;
    public Transform spawnPointPlayer2;

    // Check if the player entered the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the collider is the player
        if (other.CompareTag("Player") || other.CompareTag("Player2"))
        {
            // Transport the player to the spawn point
            other.transform.position = spawnPointPlayer1.position;
            other.transform.rotation = spawnPointPlayer1.rotation; // Optionally set rotation to match spawn point

            // Transport the player to the spawn point
            other.transform.position = spawnPointPlayer2.position;
            other.transform.rotation = spawnPointPlayer2.rotation; // Optionally set rotation to match spawn point
        }
    }
}
