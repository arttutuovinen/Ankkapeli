using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    private P1InputActions p1inputactions;

    //Shooting Cooldown
   // public float shootCooldown = 1f; // Cooldown time in seconds between shots
    //private float lastShootTime = 0f; // Time when the last shot was fired

    void Start()
    {
        p1inputactions = new P1InputActions();
    }

    void Update()
    {
        // Check if enough time has passed since the last shot
       // if (Time.time >= lastShootTime + shootCooldown)
        
            
        
               // lastShootTime = Time.time;
            
        
    }
    private void OnShoot()
    {
       Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
    }

    
}
