using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    SpriteRenderer sr;
    bool facingRight = true;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); 
    }
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.A))
        {
            if(sr != null)
            {
                sr.flipX = true;
            }
        if(Input.GetKeyDown(KeyCode.D))
            {
            sr.flipX = false;
            }
        }
    }
}
