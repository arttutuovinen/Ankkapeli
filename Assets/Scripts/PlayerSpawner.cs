using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform spawnPointPlayer1;
    public Transform spawnPointPlayer2;

    public GameObject Player1;
    public GameObject Player2;
    // Start is called before the first frame update
    void Start()
    {
        Player1.transform.position = spawnPointPlayer1.position;

        Player2.transform.position = spawnPointPlayer2.position;
    }

    
}
