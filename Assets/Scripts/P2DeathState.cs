using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class P2DeathState : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] Vector2 impulsePower;
    bool impulseRight;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        impulseRight = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Deathstate();
            Invoke ("Restore", 2.0f);
            if (gameObject.transform.rotation.eulerAngles.y == 180)
            {
                impulseRight = true;
                impulsePower = new Vector2(30.0f, 0.0f);
                rigidBody.AddForce(impulsePower, ForceMode2D.Impulse);
            }
            if (gameObject.transform.rotation.eulerAngles.y == 0)
            {
                impulseRight = false;
                impulsePower = new Vector2(-30.0f, 0.0f);
                rigidBody.AddForce(impulsePower, ForceMode2D.Impulse);
            }
        }
    }
    void Deathstate()
    {
        rigidBody.freezeRotation = false;
        gameObject.GetComponent<P2Shooting>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<P2Movement>().enabled = false;
    }
    void Restore()
    {
        rigidBody.freezeRotation = true;
        gameObject.GetComponent<P2Shooting>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<P2Movement>().enabled = true;
    }
}
