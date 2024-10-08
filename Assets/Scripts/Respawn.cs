using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPointPlayer1;
    public Transform spawnPointPlayer2;

    public GameObject Player1;
    public GameObject Player2;

    // Check if the player entered the trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            // Respawn both players to their specific spawn points
            RespawnPlayers();
            if(collision.gameObject.CompareTag("Player"))
            {
                ScoreManager.instance.AddPointP2();
            }

            if (collision.gameObject.CompareTag("Player2"))
            {
                ScoreManager.instance.AddPointP1();
            }
        }
    }

    private void RespawnPlayers()
    {
        Player1.transform.position = spawnPointPlayer1.position;

        Player2.transform.position = spawnPointPlayer2.position;
    }
}
