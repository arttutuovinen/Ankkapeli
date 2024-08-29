using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
   
    //Shooting Cooldown
    public float shootCooldown = 1f; // Cooldown time in seconds between shots
    private float lastShootTime = 0f; // Time when the last shot was fired

    void Update()
    {
        // Check if enough time has passed since the last shot
        if (Time.time >= lastShootTime + shootCooldown)
        {
            if (Input.GetKeyDown(KeyCode.Space)) // "Fire1" is usually the left mouse button or Ctrl
            {
                Shoot();
                lastShootTime = Time.time;
            }
        }
    }
    void Shoot()
    {
       Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
    }

   
}
