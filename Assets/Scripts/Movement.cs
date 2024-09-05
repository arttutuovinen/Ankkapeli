using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float RunForce = 0f;
    [SerializeField] Vector2 JumpForce;
    bool IsGrounded;
    bool FacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RunProcess();
        JumpProcess();
        FlipRotation();
    }

    void RunProcess()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(RunForce * Time.deltaTime * Vector2.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(RunForce * Time.deltaTime * Vector2.left);   
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
    void FlipRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (FacingRight == true)
            {
                gameObject.transform.Rotate(0, 180, 0);
                FacingRight = false;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (FacingRight == false)
            {
                gameObject.transform.Rotate(0, -180, 0);
                FacingRight = true;
            }
        }
    }
}  

