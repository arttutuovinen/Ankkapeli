using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P2MovementWithNewInputSystem : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float RunForce = 0f;
    [SerializeField] Vector2 JumpForce;
    bool IsGrounded = true;
    bool FacingRight = true;

    //New Input System stuff
    float move;
    private P2InputActions p2inputactions;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        p2inputactions = GetComponent<P2InputActions>();
    }



    void Update()
    {
        //tells that player moves 
        rb.AddForce(RunForce * Time.deltaTime * new Vector2(move, 0));

        FlipRotation();
    }


    private void OnMovement(InputValue moveValue)
    {
        move = moveValue.Get<float>();
    }

    private void OnJump()
    {
        print("Hypp‰‰‰‰ plz");
        if (IsGrounded)
        {
            rb.AddForce(JumpForce, ForceMode2D.Impulse);
            IsGrounded = false;
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
    void FlipRotation()
    {
        if (move < 0)
        {
            if (FacingRight == true)
            {
                gameObject.transform.Rotate(0, 180, 0);
                FacingRight = false;
            }
        }
        if (move > 0)
        {
            if (FacingRight == false)
            {
                gameObject.transform.Rotate(0, -180, 0);
                FacingRight = true;
            }
        }
    }
}
