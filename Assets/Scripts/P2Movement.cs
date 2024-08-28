using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    [SerializeField] float RunForce = 0f;
    [SerializeField] Vector2 JumpForce;
    bool IsGrounded;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        RunProcess();
        JumpProcess();
        Flip();
    }

    void RunProcess()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * RunForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * RunForce * Time.deltaTime);
        }
    }

    void JumpProcess()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded)
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
    void Flip()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(spriteRenderer != null)
            {
                spriteRenderer.flipX = true;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
        }
    }  
}
