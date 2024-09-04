using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2AnimationController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] bool runAnim;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
      RunningRight();
      RunningLeft();
      SetAnimation();
    }

    void RunningRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            runAnim = true;
        }
        else
        {
            runAnim = false;
        }
    }
    void RunningLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            runAnim = true;
        }
    }
    void SetAnimation()
    {
        if (runAnim == true)
        {
            animator.SetBool("KeyDown", true);
        }
        if (runAnim == false)
        {
            animator.SetBool("KeyDown", false);
        }
    }
}

