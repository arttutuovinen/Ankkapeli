using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class DeathState : MonoBehaviour
{
    Rigidbody2D rigidBody;
    Shooting shooting;
    [SerializeField] Vector2 impulsePower;
    bool impulseRight;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        shooting = GetComponent<Shooting>();
        impulseRight = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (gameObject.transform.rotation.eulerAngles.y == 180)
            {
                impulseRight = true;
                rigidBody.AddForce(impulsePower, ForceMode2D.Impulse);
            }
        }
    }
}
