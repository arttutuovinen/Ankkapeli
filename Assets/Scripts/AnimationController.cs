using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    bool RunAnim;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            Debug.Log("PressedButtons");
        }
    }
}

