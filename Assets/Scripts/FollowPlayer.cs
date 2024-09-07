using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;  // The player's Transform
    public Vector3 offset;             // Optional offset for positioning the sprite relative to the player

    private void Update()
    {
        // Set the position of the sprite to match the player's position (with optional offset)
        transform.position = playerTransform.position + offset;

        // Lock the rotation so the sprite doesn't rotate with the player
        transform.rotation = Quaternion.identity;
    }
}
