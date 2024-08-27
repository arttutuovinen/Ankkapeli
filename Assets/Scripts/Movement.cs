using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float RunForce = 0f;
    [SerializeField] Vector2 JumpForce;
    bool IsGrounded;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RunProcess();
        JumpProcess();
    }

    void RunProcess()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * RunForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * RunForce * Time.deltaTime);
        }
    }

    void JumpProcess()
    {
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
        {
            rb.AddForce(JumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }
    }   
}
