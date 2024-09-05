using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    bool runAnim;
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
        if (Input.GetKey(KeyCode.D))
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
        if (Input.GetKey(KeyCode.A))
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

