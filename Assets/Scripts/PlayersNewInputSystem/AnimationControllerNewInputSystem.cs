using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationControllerNewInputSystem : MonoBehaviour
{
    public Animator animator;
    bool runAnim;
    
    //New Input System stuff
    float move;
    private P1InputActions p1inputactions;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        p1inputactions = new P1InputActions();
    }


    void Update()
    {
        RunningRight();
        RunningLeft();
        SetAnimation();
    }
    private void OnMovement(InputValue moveValue)
    {
        print(moveValue.Get<float>());
        
        move = moveValue.Get<float>();
    }

    void RunningRight()
    {
        if (move > 0)
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
        if (move < 0)
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
