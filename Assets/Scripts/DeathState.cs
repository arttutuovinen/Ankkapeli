using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class DeathState : MonoBehaviour
{
    Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Deathstate();
            Invoke ("Restore", 2.0f);
        }
    }
    void Deathstate()
    {
        rigidBody.freezeRotation = false;
        gameObject.GetComponent<Shooting>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<Movement>().enabled = false;
    }
    void Restore()
    {
        rigidBody.freezeRotation = true;
        gameObject.GetComponent<Shooting>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<Movement>().enabled = true;
    }
}
